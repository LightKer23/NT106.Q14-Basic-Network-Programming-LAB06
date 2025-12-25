namespace Server
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            lbConnect = new ListBox();
            txtPort = new TextBox();
            txtIP = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            groupBox3 = new GroupBox();
            btnSendInfo = new Button();
            txtContent = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbConnect);
            groupBox1.Controls.Add(txtPort);
            groupBox1.Controls.Add(txtIP);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(27, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(335, 398);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kết nối";
            // 
            // lbConnect
            // 
            lbConnect.FormattingEnabled = true;
            lbConnect.Location = new Point(20, 121);
            lbConnect.Name = "lbConnect";
            lbConnect.Size = new Size(282, 204);
            lbConnect.TabIndex = 1;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(82, 69);
            txtPort.Name = "txtPort";
            txtPort.ReadOnly = true;
            txtPort.Size = new Size(220, 27);
            txtPort.TabIndex = 2;
            // 
            // txtIP
            // 
            txtIP.Location = new Point(82, 23);
            txtIP.Name = "txtIP";
            txtIP.ReadOnly = true;
            txtIP.Size = new Size(220, 27);
            txtIP.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 72);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "Port:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 26);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "IP:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(396, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(374, 258);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nhật ký";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 39);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(337, 200);
            textBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnSendInfo);
            groupBox3.Controls.Add(txtContent);
            groupBox3.Location = new Point(396, 291);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(374, 134);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông báo";
            // 
            // btnSendInfo
            // 
            btnSendInfo.Location = new Point(218, 77);
            btnSendInfo.Name = "btnSendInfo";
            btnSendInfo.Size = new Size(140, 40);
            btnSendInfo.TabIndex = 1;
            btnSendInfo.Text = "Gửi thông báo";
            btnSendInfo.UseVisualStyleBackColor = true;
            btnSendInfo.Click += btnSendInfo_Click;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(21, 36);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(337, 27);
            txtContent.TabIndex = 0;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Dashboard";
            ShowIcon = false;
            Text = "Dashboard";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtPort;
        private TextBox txtIP;
        private Label label2;
        private Label label1;
        private ListBox lbConnect;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private GroupBox groupBox3;
        private Button btnSendInfo;
        private TextBox txtContent;
    }
}
