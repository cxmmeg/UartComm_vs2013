using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace UartComm_vs2013
{
    public struct ComPortPar
    {
        public string PortName;
        public int BaudRate;
        public int DataBits;
        public float StopBits;
        public string Parity;
    };

    public partial class FrmMain : Form
    {
        public static ComPortPar comportParameter;
        //public static System.IO.Ports.SerialPort comPort = new System.IO.Ports.SerialPort();
        SerialPort comPort = new SerialPort();
        private string[] ports;//可用串口数组
        Thread comRecvThread;
        Queue recQueue = new Queue();//接收数据线程与数据处理线程直接传递的队列
        int recvCount;
        int sendCount;
        private bool WaitClose = false;//invoke里判断是否正在关闭串口是否正在关闭串口，执行Application.DoEvents，
                            //并阻止再次invoke ,解决关闭串口时，程序假死，具体参见http://news.ccidnet.com/art/32859/20100524/2067861_4.html

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.MaximizeBox = false;

            ports = SerialPort.GetPortNames();//获取可用串口
            if (ports.Length > 0)//有串口可用
            {
                for (int i = 0; i < ports.Length; i++)
                {
                    cbxCOMPort.Items.Add(ports[i]);//下拉控件里添加可用串口
                }
                cbxCOMPort.SelectedIndex = 0;
            }
            else//未检测到串口
            {
                tSStatusLabelComState.Text = "无可用串口";
            }

            //列出常用的波特率
            cbxBaudRate.Items.Add("9600");
            cbxBaudRate.Items.Add("19200");
            cbxBaudRate.Items.Add("38400");
            cbxBaudRate.Items.Add("57600");
            cbxBaudRate.Items.Add("115200");
            //cbxBaudRate.SelectedIndex = 3;
            cbxBaudRate.SelectedIndex = 0;//9600

            //列出数据位
            cbxDataBits.Items.Add("8");
            cbxDataBits.Items.Add("7");
            cbxDataBits.Items.Add("6");
            cbxDataBits.Items.Add("5");
            cbxDataBits.SelectedIndex = 0;

            //列出停止位
            cbxStopBits.Items.Add("0");
            cbxStopBits.Items.Add("1");
            cbxStopBits.Items.Add("1.5");
            cbxStopBits.Items.Add("2");
            cbxStopBits.SelectedIndex = 1;

            //列出奇偶校验位
            cbxParity.Items.Add("无");
            cbxParity.Items.Add("奇校验");
            cbxParity.Items.Add("偶校验");
            cbxParity.SelectedIndex = 0;
            btnClose.Enabled = false;
            comPort.DataReceived += new SerialDataReceivedEventHandler(comReceived);//串口接收中断
            comRecvThread = new Thread(new ThreadStart(ComRecv)); //查询串口接收数据线程声明
            comRecvThread.Start();//启动线程
        }

        private void comReceived(object sender, SerialDataReceivedEventArgs e)//接收数据 中断只标志有数据需要读取，读取操作在中断外进行
        {
            if (WaitClose) return;//如果正在关闭串口，则直接返回
            Thread.Sleep(10);
            if (cBoxPause.Checked)
            {
                comPort.DiscardInBuffer();//清接收缓存
            }
            else
            {
                byte[] recBuffer;//接收缓冲区
                try
                {
                    recBuffer = new byte[comPort.BytesToRead];//接收数据缓存大小
                    comPort.Read(recBuffer, 0, recBuffer.Length);//读取数据
                    recQueue.Enqueue(recBuffer);//读取数据入列Enqueue（全局）
                }
                catch
                {
                    if (!comPort.IsOpen)
                    {
                        cBoxTxRepeat.Checked = false;//将自动发送关闭，这会使得定时器不在执行发送代码
                        WaitClose = true;
                        comPort.Close();
                        cbxCOMPort.Enabled = true;
                        cbxBaudRate.Enabled = true;
                        cbxDataBits.Enabled = true;
                        cbxStopBits.Enabled = true;
                        cbxParity.Enabled = true;
                        btnOpen.Enabled = true;
                        btnClose.Enabled = false;
                        tSStatusLabelComState.Text = comPort.PortName + " 已关闭";                      
                    }
                }
            }
        }

        void ComRecv()//接收线程，窗口初始化中就开始启动运行
        {
            while (true)//持续查询串口接收线程中是否有新数据
            {
                if (recQueue.Count > 0)//串口接收线程中有新的数据
                {
                    string recData;//接收数据转码后缓存
                    byte[] recBuffer = (byte[])recQueue.Dequeue();//出列Dequeue（全局）
                    recData = System.Text.Encoding.Default.GetString(recBuffer);//转码
                    this.Invoke((EventHandler)(delegate
                    {
                        if (rBtnRxASCII.Checked)//接收模式为ASCII文本模式
                        {
                            //rtBoxRecv.Text += recData.ToString();//加显到接收区
                            rtBoxRecv.AppendText(recData/*.ToString()*/);
                        }
                        else
                        {
                            StringBuilder recBuffer16 = new StringBuilder();//定义16进制接收缓存
                            for (int i = 0; i < recBuffer.Length; i++)
                            {
                                recBuffer16.AppendFormat("{0:X2}" + " ", recBuffer[i]);//X2表示十六进制格式（大写），域宽2位，不足的左边填0。
                            }
                            //rtBoxRecv.Text = recBuffer16.ToString();//加显到接收区   
                            rtBoxRecv.AppendText(recBuffer16.ToString());
                        }
                        recvCount += recBuffer.Length;
                        tSStatusLabelRxCnt.Text = recvCount.ToString();//接收数据字节数
                        rtBoxRecv.ScrollToCaret();
                    }));
                    

                }
                else
                {
                    Thread.Sleep(100);//如果不延时，一直查询，将占用CPU过高
                }
            }
        }

        void comSend()//发送数据
        {
            byte[] sendBuffer = null;//发送数据缓冲区
            string sendData = rtBoxSend.Text;//复制发送数据，以免发送过程中数据被手动改变
            if(sendData.Length>0)//有数据可发送
            {
                if (rBtnTxHex.Checked)//16进制发送
                {
                    try //尝试将发送的数据转为16进制Hex
                    {
                        sendData = sendData.Replace(" ", "");//去除16进制数据中所有空格
                        sendData = sendData.Replace("\r", "");//去除16进制数据中所有换行
                        sendData = sendData.Replace("\n", "");//去除16进制数据中所有换行
                        if (sendData.Length == 1)//数据长度为1的时候，在数据前补0
                        {
                            sendData = "0" + sendData;
                        }
                        else if (sendData.Length % 2 != 0)//数据长度为奇数位时，去除最后一位数据
                        {
                            sendData = sendData.Remove(sendData.Length - 1, 1);
                        }

                        List<string> sendData16 = new List<string>();//将发送的数据，2个合为1个，然后放在该缓存里 如：123456→12,34,56
                        for (int i = 0; i < sendData.Length; i += 2)
                        {
                            sendData16.Add(sendData.Substring(i, 2));
                        }
                        sendBuffer = new byte[sendData16.Count];//sendBuffer的长度设置为：发送的数据2合1后的字节数
                        for (int i = 0; i < sendData16.Count; i++)
                        {
                            sendBuffer[i] = (byte)(Convert.ToInt32(sendData16[i], 16));//发送数据改为16进制
                        }
                    }
                    catch //无法转为16进制时，出现异常
                    {
                        return;//输入的16进制数据错误，无法发送，提示后返回  
                    }
                }
                else //ASCII码文本发送
                {
                    sendBuffer = System.Text.Encoding.Default.GetBytes(sendData);//转码
                }
                try//尝试发送数据
                {//如果发送字节数大于1000，则每1000字节发送一次 
                    int sendTimes = (sendBuffer.Length / 1000);//发送次数
                    for (int i = 0; i < sendTimes; i++)//每次发生1000Bytes
                    {
                        comPort.Write(sendBuffer, i * 1000, 1000);//发送sendBuffer中从第i * 1000字节开始的1000Bytes
                        sendCount += 1000;
                        this.Invoke((EventHandler)(delegate
                        {
                            tSStatusLabelTxCnt.Text = sendCount.ToString();//接收数据字节数
                        }));
                    }
                    if (sendBuffer.Length % 1000 != 0)//发送字节小于1000Bytes或上面发送剩余的数据
                    {
                        comPort.Write(sendBuffer, sendTimes * 1000, sendBuffer.Length % 1000);
                        sendCount += sendBuffer.Length % 1000;
                        this.Invoke((EventHandler)(delegate
                        {
                            tSStatusLabelTxCnt.Text = sendCount.ToString();//接收数据字节数
                        }));
                    }
                }
                catch//如果无法发送，产生异常
                {
                    this.Invoke((EventHandler)(delegate
                    {
                        cBoxTxRepeat.Checked = false;//关闭自动发送
                    }));
                    return;
                }
            }

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                comportParameter.PortName = cbxCOMPort.Text.Trim();//设置串口名
                comportParameter.BaudRate = Convert.ToInt32(cbxBaudRate.Text.Trim());//设置串口的波特率
                comportParameter.DataBits = Convert.ToInt16(cbxDataBits.Text.Trim());//设置数据位
                comportParameter.StopBits = Convert.ToSingle(cbxStopBits.Text.Trim());//设置停止位
                comportParameter.Parity = cbxParity.Text.Trim();//设置奇偶校验位

                comPort.PortName = comportParameter.PortName;
                comPort.BaudRate = comportParameter.BaudRate;
                comPort.DataBits = comportParameter.DataBits;

                if (comportParameter.StopBits == 0) comPort.StopBits = System.IO.Ports.StopBits.None;
                else if (comportParameter.StopBits == 1) comPort.StopBits = System.IO.Ports.StopBits.One;
                else if (comportParameter.StopBits == 1.5) comPort.StopBits = System.IO.Ports.StopBits.OnePointFive;
                else if (comportParameter.StopBits == 2) comPort.StopBits = System.IO.Ports.StopBits.Two;
                else comPort.StopBits = System.IO.Ports.StopBits.One;

                if (comportParameter.Parity.CompareTo("无") == 0) comPort.Parity = System.IO.Ports.Parity.None;
                else if (comportParameter.Parity.CompareTo("奇校验") == 0) comPort.Parity = System.IO.Ports.Parity.Odd;
                else if (comportParameter.Parity.CompareTo("偶校验") == 0) comPort.Parity = System.IO.Ports.Parity.Even;
                else comPort.Parity = System.IO.Ports.Parity.None;
                //comPort.Parity = System.IO.Ports.Parity.None;

                comPort.DtrEnable = false;
                comPort.RtsEnable = false;

                comPort.ReadTimeout = 5000;//[ms]
                comPort.WriteTimeout = 5000;//[ms]
                comPort.ReadBufferSize = 1024;
                comPort.WriteBufferSize = 1024;

                comPort.Open();
                if (comPort.IsOpen)
                {
                    cbxCOMPort.Enabled = false;
                    cbxBaudRate.Enabled = false;
                    cbxDataBits.Enabled = false;
                    cbxStopBits.Enabled = false;
                    cbxParity.Enabled = false;
                    btnOpen.Enabled = false;
                    btnClose.Enabled = true;
                    tSStatusLabelComState.Text = comPort.PortName + " 已打开";
                    WaitClose = false;//等待关闭串口状态改为false 
                    timerSend.Interval = (int)numUpDownInterval.Value;//发送间隔
                    if (cBoxTxRepeat.Checked) timerSend.Enabled = true;
                }
            }
            catch (Exception ex)
            { 
                comPort.Close();
                cbxCOMPort.Enabled = true;
                cbxBaudRate.Enabled = true;
                cbxDataBits.Enabled = true;
                cbxStopBits.Enabled = true;
                cbxParity.Enabled = true;
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            cBoxTxRepeat.Checked = false;//将自动发送关闭，这会使得定时器不在执行发送代码
            WaitClose = true;
            comPort.Close(); 
            cbxCOMPort.Enabled = true;
            cbxBaudRate.Enabled = true;
            cbxDataBits.Enabled = true;
            cbxStopBits.Enabled = true;
            cbxParity.Enabled = true;
            btnOpen.Enabled = true;
            btnClose.Enabled = false;
            tSStatusLabelComState.Text = comPort.PortName + " 已关闭";
        }

        private void timerSend_Tick(object sender, EventArgs e)
        {
            comSend();
        }

        private void btnCntClear_Click(object sender, EventArgs e)
        {
            recvCount = 0;
            sendCount = 0;
        }

        private void btnRxBufClear_Click(object sender, EventArgs e)
        {
            rtBoxRecv.Clear();
        }

        private void btnTxBufClear_Click(object sender, EventArgs e)
        {
            rtBoxSend.Clear();
        }

        private void numUpDownInterval_ValueChanged(object sender, EventArgs e)
        {
            timerSend.Interval = (int)numUpDownInterval.Value;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            comSend();
        }

        private void cBoxTxRepeat_CheckedChanged(object sender, EventArgs e)
        {
            timerSend.Enabled = cBoxTxRepeat.Checked;
        }

        private void btn_send_test_Click(object sender, EventArgs e)
        {
            rtBoxSend.Text = "01 02 03 ab 1e";
            comSend();
        }
    }
}
