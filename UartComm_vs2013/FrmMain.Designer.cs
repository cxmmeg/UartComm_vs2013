namespace UartComm_vs2013
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cbxDataBits = new System.Windows.Forms.ComboBox();
            this.cbxParity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxStopBits = new System.Windows.Forms.ComboBox();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.cbxCOMPort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSStatusLabelComState = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSStatusLabelRx = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSStatusLabelRxCnt = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSStatusLabelTx = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSStatusLabelTxCnt = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBoxPause = new System.Windows.Forms.CheckBox();
            this.cBoxAutoReturn = new System.Windows.Forms.CheckBox();
            this.rBtnRxHex = new System.Windows.Forms.RadioButton();
            this.rBtnRxASCII = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numUpDownInterval = new System.Windows.Forms.NumericUpDown();
            this.cBoxTxRepeat = new System.Windows.Forms.CheckBox();
            this.rBtnTxHex = new System.Windows.Forms.RadioButton();
            this.rBtnTxASCII = new System.Windows.Forms.RadioButton();
            this.rtBoxRecv = new System.Windows.Forms.RichTextBox();
            this.timerSend = new System.Windows.Forms.Timer(this.components);
            this.btnRxBufClear = new System.Windows.Forms.Button();
            this.btnTxBufClear = new System.Windows.Forms.Button();
            this.btnCntClear = new System.Windows.Forms.Button();
            this.rtBoxSend = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btn_send_test = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.cbxDataBits);
            this.groupBox1.Controls.Add(this.cbxParity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbxStopBits);
            this.groupBox1.Controls.Add(this.cbxBaudRate);
            this.groupBox1.Controls.Add(this.cbxCOMPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(111, 183);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(20, 183);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 32;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cbxDataBits
            // 
            this.cbxDataBits.FormattingEnabled = true;
            this.cbxDataBits.Location = new System.Drawing.Point(65, 88);
            this.cbxDataBits.Name = "cbxDataBits";
            this.cbxDataBits.Size = new System.Drawing.Size(121, 20);
            this.cbxDataBits.TabIndex = 31;
            // 
            // cbxParity
            // 
            this.cbxParity.FormattingEnabled = true;
            this.cbxParity.Location = new System.Drawing.Point(65, 116);
            this.cbxParity.Name = "cbxParity";
            this.cbxParity.Size = new System.Drawing.Size(121, 20);
            this.cbxParity.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 29;
            this.label4.Text = "数据位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 28;
            this.label5.Text = "校验位";
            // 
            // cbxStopBits
            // 
            this.cbxStopBits.FormattingEnabled = true;
            this.cbxStopBits.Location = new System.Drawing.Point(65, 147);
            this.cbxStopBits.Name = "cbxStopBits";
            this.cbxStopBits.Size = new System.Drawing.Size(121, 20);
            this.cbxStopBits.TabIndex = 27;
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Location = new System.Drawing.Point(65, 58);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(121, 20);
            this.cbxBaudRate.TabIndex = 26;
            // 
            // cbxCOMPort
            // 
            this.cbxCOMPort.FormattingEnabled = true;
            this.cbxCOMPort.Location = new System.Drawing.Point(65, 29);
            this.cbxCOMPort.Name = "cbxCOMPort";
            this.cbxCOMPort.Size = new System.Drawing.Size(121, 20);
            this.cbxCOMPort.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "停止位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "串口号";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSStatusLabelComState,
            this.tSStatusLabelRx,
            this.tSStatusLabelRxCnt,
            this.tSStatusLabelTx,
            this.tSStatusLabelTxCnt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 588);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1049, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSStatusLabelComState
            // 
            this.tSStatusLabelComState.AutoSize = false;
            this.tSStatusLabelComState.Name = "tSStatusLabelComState";
            this.tSStatusLabelComState.Size = new System.Drawing.Size(120, 17);
            this.tSStatusLabelComState.Text = "串口状态";
            this.tSStatusLabelComState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tSStatusLabelRx
            // 
            this.tSStatusLabelRx.AutoSize = false;
            this.tSStatusLabelRx.Name = "tSStatusLabelRx";
            this.tSStatusLabelRx.Size = new System.Drawing.Size(50, 17);
            this.tSStatusLabelRx.Text = "RxCnt:";
            // 
            // tSStatusLabelRxCnt
            // 
            this.tSStatusLabelRxCnt.AutoSize = false;
            this.tSStatusLabelRxCnt.Name = "tSStatusLabelRxCnt";
            this.tSStatusLabelRxCnt.Size = new System.Drawing.Size(100, 17);
            this.tSStatusLabelRxCnt.Text = "0";
            this.tSStatusLabelRxCnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tSStatusLabelTx
            // 
            this.tSStatusLabelTx.AutoSize = false;
            this.tSStatusLabelTx.Name = "tSStatusLabelTx";
            this.tSStatusLabelTx.Size = new System.Drawing.Size(50, 17);
            this.tSStatusLabelTx.Text = "TxCnt:";
            // 
            // tSStatusLabelTxCnt
            // 
            this.tSStatusLabelTxCnt.AutoSize = false;
            this.tSStatusLabelTxCnt.Name = "tSStatusLabelTxCnt";
            this.tSStatusLabelTxCnt.Size = new System.Drawing.Size(100, 17);
            this.tSStatusLabelTxCnt.Text = "0";
            this.tSStatusLabelTxCnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBoxPause);
            this.groupBox2.Controls.Add(this.cBoxAutoReturn);
            this.groupBox2.Controls.Add(this.rBtnRxHex);
            this.groupBox2.Controls.Add(this.rBtnRxASCII);
            this.groupBox2.Location = new System.Drawing.Point(15, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 88);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收设置";
            // 
            // cBoxPause
            // 
            this.cBoxPause.AutoSize = true;
            this.cBoxPause.Location = new System.Drawing.Point(108, 42);
            this.cBoxPause.Name = "cBoxPause";
            this.cBoxPause.Size = new System.Drawing.Size(72, 16);
            this.cBoxPause.TabIndex = 3;
            this.cBoxPause.Text = "暂停接收";
            this.cBoxPause.UseVisualStyleBackColor = true;
            // 
            // cBoxAutoReturn
            // 
            this.cBoxAutoReturn.AutoSize = true;
            this.cBoxAutoReturn.Location = new System.Drawing.Point(17, 42);
            this.cBoxAutoReturn.Name = "cBoxAutoReturn";
            this.cBoxAutoReturn.Size = new System.Drawing.Size(72, 16);
            this.cBoxAutoReturn.TabIndex = 2;
            this.cBoxAutoReturn.Text = "自动换行";
            this.cBoxAutoReturn.UseVisualStyleBackColor = true;
            // 
            // rBtnRxHex
            // 
            this.rBtnRxHex.AutoSize = true;
            this.rBtnRxHex.Checked = true;
            this.rBtnRxHex.Location = new System.Drawing.Point(108, 20);
            this.rBtnRxHex.Name = "rBtnRxHex";
            this.rBtnRxHex.Size = new System.Drawing.Size(41, 16);
            this.rBtnRxHex.TabIndex = 1;
            this.rBtnRxHex.TabStop = true;
            this.rBtnRxHex.Text = "Hex";
            this.rBtnRxHex.UseVisualStyleBackColor = true;
            // 
            // rBtnRxASCII
            // 
            this.rBtnRxASCII.AutoSize = true;
            this.rBtnRxASCII.Location = new System.Drawing.Point(17, 20);
            this.rBtnRxASCII.Name = "rBtnRxASCII";
            this.rBtnRxASCII.Size = new System.Drawing.Size(53, 16);
            this.rBtnRxASCII.TabIndex = 0;
            this.rBtnRxASCII.Text = "ASCII";
            this.rBtnRxASCII.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.numUpDownInterval);
            this.groupBox3.Controls.Add(this.cBoxTxRepeat);
            this.groupBox3.Controls.Add(this.rBtnTxHex);
            this.groupBox3.Controls.Add(this.rBtnTxASCII);
            this.groupBox3.Location = new System.Drawing.Point(8, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 74);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送设置";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "ms";
            // 
            // numUpDownInterval
            // 
            this.numUpDownInterval.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDownInterval.Location = new System.Drawing.Point(108, 42);
            this.numUpDownInterval.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numUpDownInterval.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUpDownInterval.Name = "numUpDownInterval";
            this.numUpDownInterval.Size = new System.Drawing.Size(62, 21);
            this.numUpDownInterval.TabIndex = 5;
            this.numUpDownInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDownInterval.ValueChanged += new System.EventHandler(this.numUpDownInterval_ValueChanged);
            // 
            // cBoxTxRepeat
            // 
            this.cBoxTxRepeat.AutoSize = true;
            this.cBoxTxRepeat.Location = new System.Drawing.Point(17, 45);
            this.cBoxTxRepeat.Name = "cBoxTxRepeat";
            this.cBoxTxRepeat.Size = new System.Drawing.Size(72, 16);
            this.cBoxTxRepeat.TabIndex = 4;
            this.cBoxTxRepeat.Text = "重复发送";
            this.cBoxTxRepeat.UseVisualStyleBackColor = true;
            this.cBoxTxRepeat.CheckedChanged += new System.EventHandler(this.cBoxTxRepeat_CheckedChanged);
            // 
            // rBtnTxHex
            // 
            this.rBtnTxHex.AutoSize = true;
            this.rBtnTxHex.Checked = true;
            this.rBtnTxHex.Location = new System.Drawing.Point(108, 20);
            this.rBtnTxHex.Name = "rBtnTxHex";
            this.rBtnTxHex.Size = new System.Drawing.Size(41, 16);
            this.rBtnTxHex.TabIndex = 3;
            this.rBtnTxHex.TabStop = true;
            this.rBtnTxHex.Text = "Hex";
            this.rBtnTxHex.UseVisualStyleBackColor = true;
            // 
            // rBtnTxASCII
            // 
            this.rBtnTxASCII.AutoSize = true;
            this.rBtnTxASCII.Location = new System.Drawing.Point(17, 20);
            this.rBtnTxASCII.Name = "rBtnTxASCII";
            this.rBtnTxASCII.Size = new System.Drawing.Size(53, 16);
            this.rBtnTxASCII.TabIndex = 2;
            this.rBtnTxASCII.Text = "ASCII";
            this.rBtnTxASCII.UseVisualStyleBackColor = true;
            // 
            // rtBoxRecv
            // 
            this.rtBoxRecv.Location = new System.Drawing.Point(223, 12);
            this.rtBoxRecv.Name = "rtBoxRecv";
            this.rtBoxRecv.Size = new System.Drawing.Size(415, 145);
            this.rtBoxRecv.TabIndex = 4;
            this.rtBoxRecv.Text = "";
            // 
            // timerSend
            // 
            this.timerSend.Tick += new System.EventHandler(this.timerSend_Tick);
            // 
            // btnRxBufClear
            // 
            this.btnRxBufClear.Location = new System.Drawing.Point(223, 308);
            this.btnRxBufClear.Name = "btnRxBufClear";
            this.btnRxBufClear.Size = new System.Drawing.Size(75, 23);
            this.btnRxBufClear.TabIndex = 5;
            this.btnRxBufClear.Text = "清空接收区";
            this.btnRxBufClear.UseVisualStyleBackColor = true;
            this.btnRxBufClear.Click += new System.EventHandler(this.btnRxBufClear_Click);
            // 
            // btnTxBufClear
            // 
            this.btnTxBufClear.Location = new System.Drawing.Point(319, 308);
            this.btnTxBufClear.Name = "btnTxBufClear";
            this.btnTxBufClear.Size = new System.Drawing.Size(75, 23);
            this.btnTxBufClear.TabIndex = 6;
            this.btnTxBufClear.Text = "清空发送区";
            this.btnTxBufClear.UseVisualStyleBackColor = true;
            this.btnTxBufClear.Click += new System.EventHandler(this.btnTxBufClear_Click);
            // 
            // btnCntClear
            // 
            this.btnCntClear.Location = new System.Drawing.Point(416, 308);
            this.btnCntClear.Name = "btnCntClear";
            this.btnCntClear.Size = new System.Drawing.Size(75, 23);
            this.btnCntClear.TabIndex = 7;
            this.btnCntClear.Text = "计数清零";
            this.btnCntClear.UseVisualStyleBackColor = true;
            this.btnCntClear.Click += new System.EventHandler(this.btnCntClear_Click);
            // 
            // rtBoxSend
            // 
            this.rtBoxSend.Location = new System.Drawing.Point(223, 183);
            this.rtBoxSend.Name = "rtBoxSend";
            this.rtBoxSend.Size = new System.Drawing.Size(415, 110);
            this.rtBoxSend.TabIndex = 8;
            this.rtBoxSend.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(563, 308);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btn_send_test
            // 
            this.btn_send_test.Location = new System.Drawing.Point(223, 360);
            this.btn_send_test.Name = "btn_send_test";
            this.btn_send_test.Size = new System.Drawing.Size(75, 23);
            this.btn_send_test.TabIndex = 10;
            this.btn_send_test.Text = "测试";
            this.btn_send_test.UseVisualStyleBackColor = true;
            this.btn_send_test.Click += new System.EventHandler(this.btn_send_test_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 610);
            this.Controls.Add(this.btn_send_test);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rtBoxSend);
            this.Controls.Add(this.btnCntClear);
            this.Controls.Add(this.btnTxBufClear);
            this.Controls.Add(this.btnRxBufClear);
            this.Controls.Add(this.rtBoxRecv);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "串口测试";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cbxDataBits;
        private System.Windows.Forms.ComboBox cbxParity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxStopBits;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.ComboBox cbxCOMPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tSStatusLabelComState;
        private System.Windows.Forms.ToolStripStatusLabel tSStatusLabelRxCnt;
        private System.Windows.Forms.ToolStripStatusLabel tSStatusLabelTxCnt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBtnRxASCII;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cBoxAutoReturn;
        private System.Windows.Forms.RadioButton rBtnRxHex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numUpDownInterval;
        private System.Windows.Forms.CheckBox cBoxTxRepeat;
        private System.Windows.Forms.RadioButton rBtnTxHex;
        private System.Windows.Forms.RadioButton rBtnTxASCII;
        private System.Windows.Forms.RichTextBox rtBoxRecv;
        private System.Windows.Forms.Timer timerSend;
        private System.Windows.Forms.CheckBox cBoxPause;
        private System.Windows.Forms.ToolStripStatusLabel tSStatusLabelRx;
        private System.Windows.Forms.ToolStripStatusLabel tSStatusLabelTx;
        private System.Windows.Forms.Button btnRxBufClear;
        private System.Windows.Forms.Button btnTxBufClear;
        private System.Windows.Forms.Button btnCntClear;
        private System.Windows.Forms.RichTextBox rtBoxSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btn_send_test;
    }
}

