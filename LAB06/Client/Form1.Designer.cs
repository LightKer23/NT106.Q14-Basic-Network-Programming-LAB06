namespace Client
{
    partial class TradingTerminal
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
            size = new NumericUpDown();
            date = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            emailBox = new TextBox();
            access = new Button();
            sendEmail = new Button();
            dataGridView = new DataGridView();
            StockCode = new DataGridViewTextBoxColumn();
            StockName = new DataGridViewTextBoxColumn();
            ClosePrice = new DataGridViewTextBoxColumn();
            Change = new DataGridViewTextBoxColumn();
            PerChange = new DataGridViewTextBoxColumn();
            TabControl = new TabControl();
            TerminalTrading = new TabPage();
            Message = new TabPage();
            systemMessage = new ListBox();
            ((System.ComponentModel.ISupportInitialize)size).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            TabControl.SuspendLayout();
            TerminalTrading.SuspendLayout();
            Message.SuspendLayout();
            SuspendLayout();
            // 
            // size
            // 
            size.Location = new Point(44, 39);
            size.Name = "size";
            size.Size = new Size(144, 27);
            size.TabIndex = 0;
            // 
            // date
            // 
            date.Location = new Point(324, 39);
            date.Name = "date";
            date.Size = new Size(240, 27);
            date.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 41);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 2;
            label1.Text = "Size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 41);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 3;
            label2.Text = "Date";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(44, 118);
            emailBox.Multiline = true;
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(552, 106);
            emailBox.TabIndex = 4;
            // 
            // access
            // 
            access.Location = new Point(570, 39);
            access.Name = "access";
            access.Size = new Size(90, 29);
            access.TabIndex = 5;
            access.Text = "Truy vấn";
            access.UseVisualStyleBackColor = true;
            // 
            // sendEmail
            // 
            sendEmail.Location = new Point(421, 244);
            sendEmail.Name = "sendEmail";
            sendEmail.Size = new Size(175, 29);
            sendEmail.TabIndex = 6;
            sendEmail.Text = "Xuất, gửi email";
            sendEmail.UseVisualStyleBackColor = true;
            sendEmail.Click += sendEmail_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { StockCode, StockName, ClosePrice, Change, PerChange });
            dataGridView.Location = new Point(8, 292);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 49;
            dataGridView.Size = new Size(652, 369);
            dataGridView.TabIndex = 7;
            // 
            // StockCode
            // 
            StockCode.HeaderText = "StockCode";
            StockCode.MinimumWidth = 6;
            StockCode.Name = "StockCode";
            StockCode.Width = 120;
            // 
            // StockName
            // 
            StockName.HeaderText = "StockName";
            StockName.MinimumWidth = 6;
            StockName.Name = "StockName";
            StockName.Width = 120;
            // 
            // ClosePrice
            // 
            ClosePrice.HeaderText = "ClosePrice";
            ClosePrice.MinimumWidth = 6;
            ClosePrice.Name = "ClosePrice";
            ClosePrice.Width = 120;
            // 
            // Change
            // 
            Change.HeaderText = "Change";
            Change.MinimumWidth = 6;
            Change.Name = "Change";
            Change.Width = 120;
            // 
            // PerChange
            // 
            PerChange.HeaderText = "PerChange";
            PerChange.MinimumWidth = 6;
            PerChange.Name = "PerChange";
            PerChange.Width = 120;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(TerminalTrading);
            TabControl.Controls.Add(Message);
            TabControl.Location = new Point(2, 2);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(741, 763);
            TabControl.TabIndex = 8;
            // 
            // TerminalTrading
            // 
            TerminalTrading.Controls.Add(emailBox);
            TerminalTrading.Controls.Add(dataGridView);
            TerminalTrading.Controls.Add(size);
            TerminalTrading.Controls.Add(sendEmail);
            TerminalTrading.Controls.Add(date);
            TerminalTrading.Controls.Add(access);
            TerminalTrading.Controls.Add(label1);
            TerminalTrading.Controls.Add(label2);
            TerminalTrading.Location = new Point(4, 29);
            TerminalTrading.Name = "TerminalTrading";
            TerminalTrading.Padding = new Padding(3);
            TerminalTrading.Size = new Size(733, 730);
            TerminalTrading.TabIndex = 0;
            TerminalTrading.Text = "TerminalTrading";
            TerminalTrading.UseVisualStyleBackColor = true;
            // 
            // Message
            // 
            Message.Controls.Add(systemMessage);
            Message.Location = new Point(4, 29);
            Message.Name = "Message";
            Message.Padding = new Padding(3);
            Message.Size = new Size(733, 730);
            Message.TabIndex = 1;
            Message.Text = "Message";
            Message.UseVisualStyleBackColor = true;
            // 
            // systemMessage
            // 
            systemMessage.FormattingEnabled = true;
            systemMessage.Location = new Point(0, 0);
            systemMessage.Name = "systemMessage";
            systemMessage.Size = new Size(730, 724);
            systemMessage.TabIndex = 0;
            // 
            // TradingTerminal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 764);
            Controls.Add(TabControl);
            Name = "TradingTerminal";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)size).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            TabControl.ResumeLayout(false);
            TerminalTrading.ResumeLayout(false);
            TerminalTrading.PerformLayout();
            Message.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown size;
        private DateTimePicker date;
        private Label label1;
        private Label label2;
        private TextBox emailBox;
        private Button access;
        private Button sendEmail;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn StockCode;
        private DataGridViewTextBoxColumn StockName;
        private DataGridViewTextBoxColumn ClosePrice;
        private DataGridViewTextBoxColumn Change;
        private DataGridViewTextBoxColumn PerChange;
        private TabControl TabControl;
        private TabPage TerminalTrading;
        private TabPage Message;
        private ListBox systemMessage;
    }
}
