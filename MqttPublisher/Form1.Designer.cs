namespace MqttPublisher
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEnterMessage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGetPortNumber = new System.Windows.Forms.TextBox();
            this.txtGetTopic = new System.Windows.Forms.TextBox();
            this.txtGetHowManyFor = new System.Windows.Forms.TextBox();
            this.txtGetMessage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPublish = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblHowManyCharacters = new System.Windows.Forms.Label();
            this.txtHowManyCharacters = new System.Windows.Forms.TextBox();
            this.txtGetIpAddress = new System.Windows.Forms.TextBox();
            this.lblShowMessageCount = new System.Windows.Forms.Label();
            this.lblSendedMessageCount = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cmbQosLevel = new System.Windows.Forms.ComboBox();
            this.richTbSendedMessages = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSendedTotalMessage = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Adresini Girin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port Numarasını Girin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "QoS Seviyesini Girin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Topic Girin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kaç Döngü Olacak ?";
            // 
            // lblEnterMessage
            // 
            this.lblEnterMessage.AutoSize = true;
            this.lblEnterMessage.Location = new System.Drawing.Point(7, 386);
            this.lblEnterMessage.Name = "lblEnterMessage";
            this.lblEnterMessage.Size = new System.Drawing.Size(127, 13);
            this.lblEnterMessage.TabIndex = 5;
            this.lblEnterMessage.Text = "Gönderilecek Mesajı Girin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Saniyede Giden Mesaj Sayısı = ";
            // 
            // txtGetPortNumber
            // 
            this.txtGetPortNumber.Location = new System.Drawing.Point(141, 64);
            this.txtGetPortNumber.Name = "txtGetPortNumber";
            this.txtGetPortNumber.Size = new System.Drawing.Size(100, 20);
            this.txtGetPortNumber.TabIndex = 8;
            this.txtGetPortNumber.Text = "1883";
            // 
            // txtGetTopic
            // 
            this.txtGetTopic.Location = new System.Drawing.Point(87, 189);
            this.txtGetTopic.Multiline = true;
            this.txtGetTopic.Name = "txtGetTopic";
            this.txtGetTopic.Size = new System.Drawing.Size(154, 87);
            this.txtGetTopic.TabIndex = 10;
            this.txtGetTopic.Text = "hello/world";
            // 
            // txtGetHowManyFor
            // 
            this.txtGetHowManyFor.Location = new System.Drawing.Point(120, 282);
            this.txtGetHowManyFor.Name = "txtGetHowManyFor";
            this.txtGetHowManyFor.Size = new System.Drawing.Size(41, 20);
            this.txtGetHowManyFor.TabIndex = 11;
            this.txtGetHowManyFor.Text = "5";
            // 
            // txtGetMessage
            // 
            this.txtGetMessage.Location = new System.Drawing.Point(10, 402);
            this.txtGetMessage.Multiline = true;
            this.txtGetMessage.Name = "txtGetMessage";
            this.txtGetMessage.Size = new System.Drawing.Size(240, 117);
            this.txtGetMessage.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Gönderilen Mesajlar";
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(309, 448);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(179, 57);
            this.btnPublish.TabIndex = 16;
            this.btnPublish.Text = "PUBLİSH";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.BtnPublish_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(0, 319);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(174, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Random Mesaj Gönderilsin mı ?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // lblHowManyCharacters
            // 
            this.lblHowManyCharacters.AutoSize = true;
            this.lblHowManyCharacters.Location = new System.Drawing.Point(7, 345);
            this.lblHowManyCharacters.Name = "lblHowManyCharacters";
            this.lblHowManyCharacters.Size = new System.Drawing.Size(99, 13);
            this.lblHowManyCharacters.TabIndex = 18;
            this.lblHowManyCharacters.Text = "Kaç Karakter Olsun";
            // 
            // txtHowManyCharacters
            // 
            this.txtHowManyCharacters.Location = new System.Drawing.Point(112, 342);
            this.txtHowManyCharacters.Name = "txtHowManyCharacters";
            this.txtHowManyCharacters.Size = new System.Drawing.Size(41, 20);
            this.txtHowManyCharacters.TabIndex = 19;
            // 
            // txtGetIpAddress
            // 
            this.txtGetIpAddress.Location = new System.Drawing.Point(141, 30);
            this.txtGetIpAddress.Name = "txtGetIpAddress";
            this.txtGetIpAddress.Size = new System.Drawing.Size(100, 20);
            this.txtGetIpAddress.TabIndex = 20;
            this.txtGetIpAddress.Text = "localhost";
            // 
            // lblShowMessageCount
            // 
            this.lblShowMessageCount.AutoSize = true;
            this.lblShowMessageCount.Location = new System.Drawing.Point(410, 13);
            this.lblShowMessageCount.Name = "lblShowMessageCount";
            this.lblShowMessageCount.Size = new System.Drawing.Size(0, 13);
            this.lblShowMessageCount.TabIndex = 21;
            // 
            // lblSendedMessageCount
            // 
            this.lblSendedMessageCount.AutoSize = true;
            this.lblSendedMessageCount.Location = new System.Drawing.Point(458, 13);
            this.lblSendedMessageCount.Name = "lblSendedMessageCount";
            this.lblSendedMessageCount.Size = new System.Drawing.Size(13, 13);
            this.lblSendedMessageCount.TabIndex = 22;
            this.lblSendedMessageCount.Text = "0";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(15, 113);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(102, 44);
            this.btnConnect.TabIndex = 23;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // cmbQosLevel
            // 
            this.cmbQosLevel.FormattingEnabled = true;
            this.cmbQosLevel.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cmbQosLevel.Location = new System.Drawing.Point(411, 413);
            this.cmbQosLevel.Name = "cmbQosLevel";
            this.cmbQosLevel.Size = new System.Drawing.Size(60, 21);
            this.cmbQosLevel.TabIndex = 24;
            // 
            // richTbSendedMessages
            // 
            this.richTbSendedMessages.Location = new System.Drawing.Point(265, 113);
            this.richTbSendedMessages.Name = "richTbSendedMessages";
            this.richTbSendedMessages.Size = new System.Drawing.Size(320, 275);
            this.richTbSendedMessages.TabIndex = 25;
            this.richTbSendedMessages.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Giden Toplam Mesaj Sayısı  =";
            // 
            // lblSendedTotalMessage
            // 
            this.lblSendedTotalMessage.AutoSize = true;
            this.lblSendedTotalMessage.Location = new System.Drawing.Point(458, 43);
            this.lblSendedTotalMessage.Name = "lblSendedTotalMessage";
            this.lblSendedTotalMessage.Size = new System.Drawing.Size(13, 13);
            this.lblSendedTotalMessage.TabIndex = 27;
            this.lblSendedTotalMessage.Text = "0";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(413, 87);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(141, 113);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(102, 44);
            this.btnDisconnect.TabIndex = 30;
            this.btnDisconnect.Text = "DİSCONNECT";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 553);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblSendedTotalMessage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTbSendedMessages);
            this.Controls.Add(this.cmbQosLevel);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblSendedMessageCount);
            this.Controls.Add(this.lblShowMessageCount);
            this.Controls.Add(this.txtGetIpAddress);
            this.Controls.Add(this.txtHowManyCharacters);
            this.Controls.Add(this.lblHowManyCharacters);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGetMessage);
            this.Controls.Add(this.txtGetHowManyFor);
            this.Controls.Add(this.txtGetTopic);
            this.Controls.Add(this.txtGetPortNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblEnterMessage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEnterMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGetPortNumber;
        private System.Windows.Forms.TextBox txtGetTopic;
        private System.Windows.Forms.TextBox txtGetHowManyFor;
        private System.Windows.Forms.TextBox txtGetMessage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblHowManyCharacters;
        private System.Windows.Forms.TextBox txtHowManyCharacters;
        private System.Windows.Forms.TextBox txtGetIpAddress;
        private System.Windows.Forms.Label lblShowMessageCount;
        private System.Windows.Forms.Label lblSendedMessageCount;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cmbQosLevel;
        private System.Windows.Forms.RichTextBox richTbSendedMessages;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSendedTotalMessage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDisconnect;
    }
}

