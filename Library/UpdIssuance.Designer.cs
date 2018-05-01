namespace Library
{
    partial class UpdIssuance
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
            this.dtpE = new System.Windows.Forms.DateTimePicker();
            this.dtpB = new System.Windows.Forms.DateTimePicker();
            this.cbBook = new System.Windows.Forms.ComboBox();
            this.cbReader = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnIssuance = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Билет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Книга";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Выдача";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(13, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Статус";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(13, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Возврат";
            // 
            // dtpE
            // 
            this.dtpE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpE.CalendarTitleBackColor = global::Library.Properties.Settings.Default.ButtonBlue;
            this.dtpE.DataBindings.Add(new System.Windows.Forms.Binding("CalendarTitleBackColor", global::Library.Properties.Settings.Default, "ButtonBlue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dtpE.Location = new System.Drawing.Point(67, 107);
            this.dtpE.Name = "dtpE";
            this.dtpE.Size = new System.Drawing.Size(368, 20);
            this.dtpE.TabIndex = 8;
            // 
            // dtpB
            // 
            this.dtpB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpB.CalendarTitleBackColor = global::Library.Properties.Settings.Default.ButtonBlue;
            this.dtpB.DataBindings.Add(new System.Windows.Forms.Binding("CalendarTitleBackColor", global::Library.Properties.Settings.Default, "ButtonBlue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dtpB.Location = new System.Drawing.Point(67, 81);
            this.dtpB.Name = "dtpB";
            this.dtpB.Size = new System.Drawing.Size(368, 20);
            this.dtpB.TabIndex = 7;
            // 
            // cbBook
            // 
            this.cbBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBook.FormattingEnabled = true;
            this.cbBook.Location = new System.Drawing.Point(67, 46);
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(370, 21);
            this.cbBook.TabIndex = 6;
            this.cbBook.Text = "Книга";
            // 
            // cbReader
            // 
            this.cbReader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbReader.FormattingEnabled = true;
            this.cbReader.Location = new System.Drawing.Point(67, 19);
            this.cbReader.Name = "cbReader";
            this.cbReader.Size = new System.Drawing.Size(368, 21);
            this.cbReader.TabIndex = 5;
            this.cbReader.Text = "Читательский билет";
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Выдано",
            "Принято"});
            this.cbStatus.Location = new System.Drawing.Point(67, 150);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(370, 21);
            this.cbStatus.TabIndex = 9;
            // 
            // btnIssuance
            // 
            this.btnIssuance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIssuance.BackColor = global::Library.Properties.Settings.Default.ButtonGreen;
            this.btnIssuance.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Library.Properties.Settings.Default, "ButtonGreen", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnIssuance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIssuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIssuance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIssuance.Location = new System.Drawing.Point(16, 184);
            this.btnIssuance.Name = "btnIssuance";
            this.btnIssuance.Size = new System.Drawing.Size(206, 41);
            this.btnIssuance.TabIndex = 10;
            this.btnIssuance.Text = "Изменить";
            this.btnIssuance.UseVisualStyleBackColor = false;
            this.btnIssuance.Click += new System.EventHandler(this.btnIssuance_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.BackColor = global::Library.Properties.Settings.Default.ButtonRed;
            this.btnDel.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Library.Properties.Settings.Default, "ButtonRed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDel.Location = new System.Drawing.Point(229, 184);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(206, 41);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // UpdIssuance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Library.Properties.Settings.Default.MainColor;
            this.ClientSize = new System.Drawing.Size(447, 237);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnIssuance);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.dtpE);
            this.Controls.Add(this.dtpB);
            this.Controls.Add(this.cbBook);
            this.Controls.Add(this.cbReader);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Library.Properties.Settings.Default, "MainColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "UpdIssuance";
            this.Text = "Изменить операцию";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpE;
        private System.Windows.Forms.DateTimePicker dtpB;
        private System.Windows.Forms.ComboBox cbBook;
        private System.Windows.Forms.ComboBox cbReader;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnIssuance;
        private System.Windows.Forms.Button btnDel;
    }
}