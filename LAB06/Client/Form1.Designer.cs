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
            ((System.ComponentModel.ISupportInitialize)size).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // size
            // 
            size.Location = new Point(86, 12);
            size.Name = "size";
            size.Size = new Size(144, 26);
            size.TabIndex = 0;
            // 
            // date
            // 
            date.Location = new Point(366, 12);
            date.Name = "date";
            date.Size = new Size(240, 26);
            date.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 14);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 2;
            label1.Text = "Size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 14);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 3;
            label2.Text = "Date";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(86, 87);
            emailBox.Multiline = true;
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(552, 101);
            emailBox.TabIndex = 4;
            // 
            // access
            // 
            access.Location = new Point(612, 12);
            access.Name = "access";
            access.Size = new Size(90, 28);
            access.TabIndex = 5;
            access.Text = "Truy vấn";
            access.UseVisualStyleBackColor = true;
            // 
            // sendEmail
            // 
            sendEmail.Location = new Point(463, 206);
            sendEmail.Name = "sendEmail";
            sendEmail.Size = new Size(175, 28);
            sendEmail.TabIndex = 6;
            sendEmail.Text = "Xuất, gửi email";
            sendEmail.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { StockCode, StockName, ClosePrice, Change, PerChange });
            dataGridView.Location = new Point(50, 252);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 49;
            dataGridView.Size = new Size(652, 351);
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
            // TradingTerminal
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 675);
            Controls.Add(dataGridView);
            Controls.Add(sendEmail);
            Controls.Add(access);
            Controls.Add(emailBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(date);
            Controls.Add(size);
            Name = "TradingTerminal";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)size).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}
