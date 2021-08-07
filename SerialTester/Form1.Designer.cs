
namespace SerialTester
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Disconect = new System.Windows.Forms.Button();
            this.RtsEnable = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DtrEnable = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.HandshakeTxt = new System.Windows.Forms.ComboBox();
            this.StopBitsTxt = new System.Windows.Forms.ComboBox();
            this.ParityTxt = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WriteTimeout = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ReadTimeout = new System.Windows.Forms.TextBox();
            this.DataBits = new System.Windows.Forms.TextBox();
            this.BaudRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.portName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sendTxt = new System.Windows.Forms.TextBox();
            this.reciveTxt = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.interval = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.openClose = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.tSend = new System.Windows.Forms.Button();
            this.cSend = new System.Windows.Forms.Button();
            this.mSend = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(502, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 383);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(502, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Disconect);
            this.groupBox1.Controls.Add(this.RtsEnable);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.DtrEnable);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Connect);
            this.groupBox1.Controls.Add(this.HandshakeTxt);
            this.groupBox1.Controls.Add(this.StopBitsTxt);
            this.groupBox1.Controls.Add(this.ParityTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.WriteTimeout);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ReadTimeout);
            this.groupBox1.Controls.Add(this.DataBits);
            this.groupBox1.Controls.Add(this.BaudRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.portName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 339);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Open Port";
            // 
            // Disconect
            // 
            this.Disconect.Enabled = false;
            this.Disconect.Location = new System.Drawing.Point(123, 300);
            this.Disconect.Name = "Disconect";
            this.Disconect.Size = new System.Drawing.Size(74, 23);
            this.Disconect.TabIndex = 18;
            this.Disconect.Text = "Disconect";
            this.Disconect.UseVisualStyleBackColor = true;
            this.Disconect.Click += new System.EventHandler(this.Disconect_Click);
            // 
            // RtsEnable
            // 
            this.RtsEnable.AutoSize = true;
            this.RtsEnable.Location = new System.Drawing.Point(97, 268);
            this.RtsEnable.Name = "RtsEnable";
            this.RtsEnable.Size = new System.Drawing.Size(75, 17);
            this.RtsEnable.TabIndex = 17;
            this.RtsEnable.Text = "RtsEnable";
            this.RtsEnable.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Write Timeout ";
            // 
            // DtrEnable
            // 
            this.DtrEnable.AutoSize = true;
            this.DtrEnable.Location = new System.Drawing.Point(97, 245);
            this.DtrEnable.Name = "DtrEnable";
            this.DtrEnable.Size = new System.Drawing.Size(73, 17);
            this.DtrEnable.TabIndex = 7;
            this.DtrEnable.Text = "DtrEnable";
            this.DtrEnable.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Read Timeout ";
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(21, 300);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(74, 23);
            this.Connect.TabIndex = 3;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // HandshakeTxt
            // 
            this.HandshakeTxt.FormattingEnabled = true;
            this.HandshakeTxt.Items.AddRange(new object[] {
            "None",
            "RequestToSend",
            "RequestToSendXOnXOff",
            "XOnXOff"});
            this.HandshakeTxt.Location = new System.Drawing.Point(97, 166);
            this.HandshakeTxt.Name = "HandshakeTxt";
            this.HandshakeTxt.Size = new System.Drawing.Size(100, 21);
            this.HandshakeTxt.TabIndex = 11;
            this.HandshakeTxt.Text = "None";
            // 
            // StopBitsTxt
            // 
            this.StopBitsTxt.FormattingEnabled = true;
            this.StopBitsTxt.Items.AddRange(new object[] {
            "One",
            "Two",
            "None",
            "OnePointFive"});
            this.StopBitsTxt.Location = new System.Drawing.Point(97, 140);
            this.StopBitsTxt.Name = "StopBitsTxt";
            this.StopBitsTxt.Size = new System.Drawing.Size(100, 21);
            this.StopBitsTxt.TabIndex = 10;
            this.StopBitsTxt.Text = "One";
            // 
            // ParityTxt
            // 
            this.ParityTxt.FormattingEnabled = true;
            this.ParityTxt.Items.AddRange(new object[] {
            "None",
            "Mark",
            "Even",
            "Odd",
            "Space"});
            this.ParityTxt.Location = new System.Drawing.Point(97, 115);
            this.ParityTxt.Name = "ParityTxt";
            this.ParityTxt.Size = new System.Drawing.Size(100, 21);
            this.ParityTxt.TabIndex = 9;
            this.ParityTxt.Text = "None";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Handshake";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Stop Bits";
            // 
            // WriteTimeout
            // 
            this.WriteTimeout.Location = new System.Drawing.Point(97, 219);
            this.WriteTimeout.Name = "WriteTimeout";
            this.WriteTimeout.Size = new System.Drawing.Size(100, 20);
            this.WriteTimeout.TabIndex = 9;
            this.WriteTimeout.Text = "500";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Parity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Data Bits";
            // 
            // ReadTimeout
            // 
            this.ReadTimeout.Location = new System.Drawing.Point(97, 193);
            this.ReadTimeout.Name = "ReadTimeout";
            this.ReadTimeout.Size = new System.Drawing.Size(100, 20);
            this.ReadTimeout.TabIndex = 9;
            this.ReadTimeout.Text = "500";
            // 
            // DataBits
            // 
            this.DataBits.Location = new System.Drawing.Point(97, 89);
            this.DataBits.Name = "DataBits";
            this.DataBits.Size = new System.Drawing.Size(100, 20);
            this.DataBits.TabIndex = 9;
            this.DataBits.Text = "8";
            // 
            // BaudRate
            // 
            this.BaudRate.Location = new System.Drawing.Point(97, 63);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(100, 20);
            this.BaudRate.TabIndex = 9;
            this.BaudRate.Text = "9600";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Baud Rate";
            // 
            // portName
            // 
            this.portName.Location = new System.Drawing.Point(97, 37);
            this.portName.Name = "portName";
            this.portName.Size = new System.Drawing.Size(100, 20);
            this.portName.TabIndex = 9;
            this.portName.Text = "COM5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Port Name";
            // 
            // sendTxt
            // 
            this.sendTxt.Location = new System.Drawing.Point(23, 64);
            this.sendTxt.Name = "sendTxt";
            this.sendTxt.Size = new System.Drawing.Size(141, 20);
            this.sendTxt.TabIndex = 5;
            this.sendTxt.TextChanged += new System.EventHandler(this.sendTxt_TextChanged);
            // 
            // reciveTxt
            // 
            this.reciveTxt.Location = new System.Drawing.Point(23, 113);
            this.reciveTxt.Name = "reciveTxt";
            this.reciveTxt.Size = new System.Drawing.Size(195, 158);
            this.reciveTxt.TabIndex = 6;
            this.reciveTxt.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.interval);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.openClose);
            this.groupBox2.Controls.Add(this.sendBtn);
            this.groupBox2.Controls.Add(this.tSend);
            this.groupBox2.Controls.Add(this.cSend);
            this.groupBox2.Controls.Add(this.mSend);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.reciveTxt);
            this.groupBox2.Controls.Add(this.sendTxt);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(244, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 339);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send/Recive";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(154, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "ms";
            // 
            // interval
            // 
            this.interval.Location = new System.Drawing.Point(66, 281);
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(82, 20);
            this.interval.TabIndex = 18;
            this.interval.Text = "5000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Interval";
            // 
            // openClose
            // 
            this.openClose.Location = new System.Drawing.Point(154, 310);
            this.openClose.Name = "openClose";
            this.openClose.Size = new System.Drawing.Size(64, 23);
            this.openClose.TabIndex = 16;
            this.openClose.Text = "O/C";
            this.openClose.UseVisualStyleBackColor = true;
            this.openClose.Click += new System.EventHandler(this.openClose_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(170, 62);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(48, 23);
            this.sendBtn.TabIndex = 15;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // tSend
            // 
            this.tSend.Location = new System.Drawing.Point(110, 310);
            this.tSend.Name = "tSend";
            this.tSend.Size = new System.Drawing.Size(38, 23);
            this.tSend.TabIndex = 14;
            this.tSend.Text = "T";
            this.tSend.UseVisualStyleBackColor = true;
            this.tSend.Click += new System.EventHandler(this.tSend_Click);
            // 
            // cSend
            // 
            this.cSend.Location = new System.Drawing.Point(66, 310);
            this.cSend.Name = "cSend";
            this.cSend.Size = new System.Drawing.Size(38, 23);
            this.cSend.TabIndex = 13;
            this.cSend.Text = "C";
            this.cSend.UseVisualStyleBackColor = true;
            this.cSend.Click += new System.EventHandler(this.cSend_Click);
            // 
            // mSend
            // 
            this.mSend.Location = new System.Drawing.Point(22, 310);
            this.mSend.Name = "mSend";
            this.mSend.Size = new System.Drawing.Size(38, 23);
            this.mSend.TabIndex = 12;
            this.mSend.Text = "O";
            this.mSend.UseVisualStyleBackColor = true;
            this.mSend.Click += new System.EventHandler(this.mSend_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Recive";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Send";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "About Me";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabel1.Text = "Serial Port Tester";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 405);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TextBox sendTxt;
        private System.Windows.Forms.RichTextBox reciveTxt;
        private System.Windows.Forms.CheckBox DtrEnable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox StopBitsTxt;
        private System.Windows.Forms.ComboBox ParityTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DataBits;
        private System.Windows.Forms.TextBox BaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WriteTimeout;
        private System.Windows.Forms.TextBox ReadTimeout;
        private System.Windows.Forms.ComboBox HandshakeTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox RtsEnable;
        private System.Windows.Forms.Button Disconect;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button tSend;
        private System.Windows.Forms.Button cSend;
        private System.Windows.Forms.Button mSend;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox interval;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button openClose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

