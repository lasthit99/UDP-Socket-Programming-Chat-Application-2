namespace UDP_Chat_Client_Form
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
            this.btnSendBroadcast = new System.Windows.Forms.Button();
            this.tbBroadcastText = new System.Windows.Forms.TextBox();
            this.tbRemotePort = new System.Windows.Forms.TextBox();
            this.tbLocalPort = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbConsole = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFileSelectedPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSendImage = new System.Windows.Forms.Button();
            this.pbImageReceived = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageReceived)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Remote Port: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broadcast Text:";
            // 
            // btnSendBroadcast
            // 
            this.btnSendBroadcast.Location = new System.Drawing.Point(579, 11);
            this.btnSendBroadcast.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendBroadcast.Name = "btnSendBroadcast";
            this.btnSendBroadcast.Size = new System.Drawing.Size(100, 44);
            this.btnSendBroadcast.TabIndex = 3;
            this.btnSendBroadcast.Text = "&Broadcast";
            this.btnSendBroadcast.UseVisualStyleBackColor = true;
            this.btnSendBroadcast.Click += new System.EventHandler(this.btnSendBroadcast_Click);
            // 
            // tbBroadcastText
            // 
            this.tbBroadcastText.Location = new System.Drawing.Point(117, 82);
            this.tbBroadcastText.Margin = new System.Windows.Forms.Padding(4);
            this.tbBroadcastText.Name = "tbBroadcastText";
            this.tbBroadcastText.Size = new System.Drawing.Size(132, 22);
            this.tbBroadcastText.TabIndex = 4;
            this.tbBroadcastText.Text = "<DISCOVER>";
            // 
            // tbRemotePort
            // 
            this.tbRemotePort.Location = new System.Drawing.Point(117, 50);
            this.tbRemotePort.Margin = new System.Windows.Forms.Padding(4);
            this.tbRemotePort.Name = "tbRemotePort";
            this.tbRemotePort.Size = new System.Drawing.Size(132, 22);
            this.tbRemotePort.TabIndex = 5;
            this.tbRemotePort.Text = "23000";
            // 
            // tbLocalPort
            // 
            this.tbLocalPort.Location = new System.Drawing.Point(117, 18);
            this.tbLocalPort.Margin = new System.Windows.Forms.Padding(4);
            this.tbLocalPort.Name = "tbLocalPort";
            this.tbLocalPort.Size = new System.Drawing.Size(132, 22);
            this.tbLocalPort.TabIndex = 6;
            this.tbLocalPort.Text = "23001";
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(579, 63);
            this.btnSendMessage.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(100, 44);
            this.btnSendMessage.TabIndex = 7;
            this.btnSendMessage.Text = "&Mesaj Gönder";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(259, 34);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(4);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(311, 72);
            this.tbMessage.TabIndex = 9;
            this.tbMessage.Text = "Sistem Programlama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mesaj :";
            // 
            // tbConsole
            // 
            this.tbConsole.Location = new System.Drawing.Point(4, 138);
            this.tbConsole.Margin = new System.Windows.Forms.Padding(4);
            this.tbConsole.Multiline = true;
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.Size = new System.Drawing.Size(673, 351);
            this.tbConsole.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Console:";
            // 
            // tbFileSelectedPath
            // 
            this.tbFileSelectedPath.Location = new System.Drawing.Point(772, 15);
            this.tbFileSelectedPath.Margin = new System.Windows.Forms.Padding(4);
            this.tbFileSelectedPath.Name = "tbFileSelectedPath";
            this.tbFileSelectedPath.Size = new System.Drawing.Size(547, 22);
            this.tbFileSelectedPath.TabIndex = 13;
            this.tbFileSelectedPath.Text = "C:\\Program Files (x86)\\jerry.jpg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(687, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Local Port:";
            // 
            // btnSendImage
            // 
            this.btnSendImage.Location = new System.Drawing.Point(772, 47);
            this.btnSendImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendImage.Name = "btnSendImage";
            this.btnSendImage.Size = new System.Drawing.Size(548, 44);
            this.btnSendImage.TabIndex = 14;
            this.btnSendImage.Text = "Fotoğraf &Gönder";
            this.btnSendImage.UseVisualStyleBackColor = true;
            this.btnSendImage.Click += new System.EventHandler(this.btnSendImage_Click);
            // 
            // pbImageReceived
            // 
            this.pbImageReceived.Location = new System.Drawing.Point(772, 138);
            this.pbImageReceived.Margin = new System.Windows.Forms.Padding(4);
            this.pbImageReceived.Name = "pbImageReceived";
            this.pbImageReceived.Size = new System.Drawing.Size(548, 352);
            this.pbImageReceived.TabIndex = 15;
            this.pbImageReceived.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 505);
            this.Controls.Add(this.pbImageReceived);
            this.Controls.Add(this.btnSendImage);
            this.Controls.Add(this.tbFileSelectedPath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbConsole);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.tbLocalPort);
            this.Controls.Add(this.tbRemotePort);
            this.Controls.Add(this.tbBroadcastText);
            this.Controls.Add(this.btnSendBroadcast);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Client Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageReceived)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSendBroadcast;
        private System.Windows.Forms.TextBox tbBroadcastText;
        private System.Windows.Forms.TextBox tbRemotePort;
        private System.Windows.Forms.TextBox tbLocalPort;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbConsole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFileSelectedPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSendImage;
        private System.Windows.Forms.PictureBox pbImageReceived;
    }
}

