namespace GIU_ReBorn
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.clientReceivedBytes = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.counterNetwork = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.realConnectBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.totalBytesRecBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.clientSendButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.receivedDataClient = new System.Windows.Forms.TextBox();
            this.clientDataToSend = new System.Windows.Forms.TextBox();
            this.clientConnectButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.clientConnectionDetails = new System.Windows.Forms.TextBox();
            this.clientPort = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.clientIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer();
            this.timer2 = new System.Windows.Forms.Timer();
            this.timer3 = new System.Windows.Forms.Timer();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 439);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.clientReceivedBytes);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.counterNetwork);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.realConnectBox);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.totalBytesRecBox);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.clientSendButton);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.receivedDataClient);
            this.tabPage3.Controls.Add(this.clientDataToSend);
            this.tabPage3.Controls.Add(this.clientConnectButton);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.clientConnectionDetails);
            this.tabPage3.Controls.Add(this.clientPort);
            this.tabPage3.Controls.Add(this.splitter1);
            this.tabPage3.Controls.Add(this.clientIP);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(784, 410);
            this.tabPage3.Text = "Test Meriam";
            // 
            // clientReceivedBytes
            // 
            this.clientReceivedBytes.Location = new System.Drawing.Point(634, 156);
            this.clientReceivedBytes.Name = "clientReceivedBytes";
            this.clientReceivedBytes.Size = new System.Drawing.Size(100, 23);
            this.clientReceivedBytes.TabIndex = 63;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(634, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 20);
            this.label16.Text = "Counter";
            // 
            // counterNetwork
            // 
            this.counterNetwork.Location = new System.Drawing.Point(634, 127);
            this.counterNetwork.Name = "counterNetwork";
            this.counterNetwork.Size = new System.Drawing.Size(100, 23);
            this.counterNetwork.TabIndex = 48;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(321, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 20);
            this.label15.Text = "Total Bytes";
            // 
            // realConnectBox
            // 
            this.realConnectBox.Location = new System.Drawing.Point(445, 127);
            this.realConnectBox.Name = "realConnectBox";
            this.realConnectBox.Size = new System.Drawing.Size(100, 23);
            this.realConnectBox.TabIndex = 45;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(321, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 20);
            this.label14.Text = "Real Connect";
            // 
            // totalBytesRecBox
            // 
            this.totalBytesRecBox.Location = new System.Drawing.Point(445, 156);
            this.totalBytesRecBox.Name = "totalBytesRecBox";
            this.totalBytesRecBox.Size = new System.Drawing.Size(100, 23);
            this.totalBytesRecBox.TabIndex = 43;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(498, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 20);
            this.button2.TabIndex = 30;
            this.button2.Text = "Send";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(390, 261);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 23);
            this.textBox6.TabIndex = 29;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(390, 230);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(321, 264);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.Text = "Received";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(321, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.Text = "Send";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(321, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.Text = "Serial 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 20);
            this.button1.TabIndex = 24;
            this.button1.Text = "Send";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(110, 262);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 233);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(46, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.Text = "Received";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(46, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.Text = "Send";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(46, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.Text = "Serial 1";
            // 
            // clientSendButton
            // 
            this.clientSendButton.Location = new System.Drawing.Point(555, 46);
            this.clientSendButton.Name = "clientSendButton";
            this.clientSendButton.Size = new System.Drawing.Size(72, 20);
            this.clientSendButton.TabIndex = 12;
            this.clientSendButton.Text = "Send";
            this.clientSendButton.Click += new System.EventHandler(this.clientSendButton_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(321, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.Text = "Received";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(321, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.Text = "Send";
            // 
            // receivedDataClient
            // 
            this.receivedDataClient.Location = new System.Drawing.Point(445, 73);
            this.receivedDataClient.Name = "receivedDataClient";
            this.receivedDataClient.Size = new System.Drawing.Size(100, 23);
            this.receivedDataClient.TabIndex = 9;
            // 
            // clientDataToSend
            // 
            this.clientDataToSend.Location = new System.Drawing.Point(445, 46);
            this.clientDataToSend.Name = "clientDataToSend";
            this.clientDataToSend.Size = new System.Drawing.Size(100, 23);
            this.clientDataToSend.TabIndex = 8;
            // 
            // clientConnectButton
            // 
            this.clientConnectButton.Location = new System.Drawing.Point(126, 104);
            this.clientConnectButton.Name = "clientConnectButton";
            this.clientConnectButton.Size = new System.Drawing.Size(72, 20);
            this.clientConnectButton.TabIndex = 7;
            this.clientConnectButton.Text = "Connect";
            this.clientConnectButton.Click += new System.EventHandler(this.clientConnectButton_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(321, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.Text = "Connection Details";
            // 
            // clientConnectionDetails
            // 
            this.clientConnectionDetails.Location = new System.Drawing.Point(445, 101);
            this.clientConnectionDetails.Name = "clientConnectionDetails";
            this.clientConnectionDetails.Size = new System.Drawing.Size(100, 23);
            this.clientConnectionDetails.TabIndex = 5;
            // 
            // clientPort
            // 
            this.clientPort.Location = new System.Drawing.Point(126, 75);
            this.clientPort.Name = "clientPort";
            this.clientPort.Size = new System.Drawing.Size(100, 23);
            this.clientPort.TabIndex = 4;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 410);
            // 
            // clientIP
            // 
            this.clientIP.Location = new System.Drawing.Point(126, 46);
            this.clientIP.Name = "clientIP";
            this.clientIP.Size = new System.Drawing.Size(100, 23);
            this.clientIP.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(46, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(46, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "IP Address";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(784, 410);
            this.tabPage1.Text = "Gun Position";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "Elevation";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Azimuth";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(798, 445);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "GIU";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button clientSendButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox receivedDataClient;
        private System.Windows.Forms.TextBox clientDataToSend;
        private System.Windows.Forms.Button clientConnectButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox clientConnectionDetails;
        private System.Windows.Forms.TextBox clientPort;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox clientIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox totalBytesRecBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox realConnectBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox counterNetwork;
        private System.Windows.Forms.TextBox clientReceivedBytes;
        private System.Windows.Forms.Timer timer3;
        
    }
}

