namespace Library
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvIssuance = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIssuance = new System.Windows.Forms.Button();
            this.dtpE = new System.Windows.Forms.DateTimePicker();
            this.dtpB = new System.Windows.Forms.DateTimePicker();
            this.cbBook = new System.Windows.Forms.ComboBox();
            this.cbReader = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnAddReader = new System.Windows.Forms.Button();
            this.btnAddBooks = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuance)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvIssuance, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(721, 495);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvIssuance
            // 
            this.dgvIssuance.AllowUserToAddRows = false;
            this.dgvIssuance.AllowUserToDeleteRows = false;
            this.dgvIssuance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIssuance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvIssuance.BackgroundColor = global::Library.Properties.Settings.Default.ButtonRed;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(148)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIssuance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIssuance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvIssuance, 2);
            this.dgvIssuance.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::Library.Properties.Settings.Default, "ButtonRed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dgvIssuance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIssuance.Location = new System.Drawing.Point(3, 3);
            this.dgvIssuance.MultiSelect = false;
            this.dgvIssuance.Name = "dgvIssuance";
            this.dgvIssuance.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(148)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIssuance.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIssuance.RowHeadersVisible = false;
            this.dgvIssuance.Size = new System.Drawing.Size(715, 241);
            this.dgvIssuance.TabIndex = 0;
            this.dgvIssuance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIssuance_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnIssuance);
            this.groupBox1.Controls.Add(this.dtpE);
            this.groupBox1.Controls.Add(this.dtpB);
            this.groupBox1.Controls.Add(this.cbBook);
            this.groupBox1.Controls.Add(this.cbReader);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(3, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 242);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Новая выдача";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Книга";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Билет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "До";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выдана";
            // 
            // btnIssuance
            // 
            this.btnIssuance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIssuance.BackColor = global::Library.Properties.Settings.Default.ButtonRed;
            this.btnIssuance.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Library.Properties.Settings.Default, "ButtonRed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnIssuance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIssuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIssuance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIssuance.Location = new System.Drawing.Point(9, 163);
            this.btnIssuance.Name = "btnIssuance";
            this.btnIssuance.Size = new System.Drawing.Size(339, 41);
            this.btnIssuance.TabIndex = 4;
            this.btnIssuance.Text = "Готово";
            this.btnIssuance.UseVisualStyleBackColor = false;
            this.btnIssuance.Click += new System.EventHandler(this.btnIssuance_Click);
            // 
            // dtpE
            // 
            this.dtpE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpE.CalendarTitleBackColor = global::Library.Properties.Settings.Default.ButtonBlue;
            this.dtpE.DataBindings.Add(new System.Windows.Forms.Binding("CalendarTitleBackColor", global::Library.Properties.Settings.Default, "ButtonBlue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dtpE.Location = new System.Drawing.Point(51, 130);
            this.dtpE.Name = "dtpE";
            this.dtpE.Size = new System.Drawing.Size(298, 20);
            this.dtpE.TabIndex = 3;
            // 
            // dtpB
            // 
            this.dtpB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpB.CalendarTitleBackColor = global::Library.Properties.Settings.Default.ButtonBlue;
            this.dtpB.DataBindings.Add(new System.Windows.Forms.Binding("CalendarTitleBackColor", global::Library.Properties.Settings.Default, "ButtonBlue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dtpB.Location = new System.Drawing.Point(51, 104);
            this.dtpB.Name = "dtpB";
            this.dtpB.Size = new System.Drawing.Size(299, 20);
            this.dtpB.TabIndex = 2;
            // 
            // cbBook
            // 
            this.cbBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBook.FormattingEnabled = true;
            this.cbBook.Location = new System.Drawing.Point(51, 69);
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(299, 21);
            this.cbBook.TabIndex = 1;
            this.cbBook.Text = "Книга";
            // 
            // cbReader
            // 
            this.cbReader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbReader.FormattingEnabled = true;
            this.cbReader.Location = new System.Drawing.Point(51, 42);
            this.cbReader.Name = "cbReader";
            this.cbReader.Size = new System.Drawing.Size(298, 21);
            this.cbReader.TabIndex = 0;
            this.cbReader.Text = "Читательский билет";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnUpd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnExit, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnInfo, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnReport, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddReader, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnAddBooks, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(363, 250);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(355, 242);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnUpd
            // 
            this.btnUpd.BackColor = global::Library.Properties.Settings.Default.ButtonBlue;
            this.btnUpd.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Library.Properties.Settings.Default, "Button", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnUpd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpd.Location = new System.Drawing.Point(3, 3);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(171, 74);
            this.btnUpd.TabIndex = 10;
            this.btnUpd.Text = "Обновить операции";
            this.btnUpd.UseVisualStyleBackColor = false;
            this.btnUpd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = global::Library.Properties.Settings.Default.ButtonRed;
            this.btnExit.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Library.Properties.Settings.Default, "ButtonRed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(180, 163);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 74);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = global::Library.Properties.Settings.Default.ButtonBlue;
            this.btnInfo.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Library.Properties.Settings.Default, "Button", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInfo.Location = new System.Drawing.Point(3, 163);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(171, 74);
            this.btnInfo.TabIndex = 7;
            this.btnInfo.Text = "Справка";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = global::Library.Properties.Settings.Default.ButtonGreen;
            this.btnReport.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Library.Properties.Settings.Default, "ButtonGreen", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReport.Location = new System.Drawing.Point(180, 3);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(171, 74);
            this.btnReport.TabIndex = 8;
            this.btnReport.Text = "Отчет";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnAddReader
            // 
            this.btnAddReader.BackColor = global::Library.Properties.Settings.Default.ButtonGreen;
            this.btnAddReader.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Library.Properties.Settings.Default, "ButtonGreen", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnAddReader.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddReader.Location = new System.Drawing.Point(3, 83);
            this.btnAddReader.Name = "btnAddReader";
            this.btnAddReader.Size = new System.Drawing.Size(171, 74);
            this.btnAddReader.TabIndex = 6;
            this.btnAddReader.Text = "Читатели";
            this.btnAddReader.UseVisualStyleBackColor = false;
            this.btnAddReader.Click += new System.EventHandler(this.btnAddReader_Click);
            // 
            // btnAddBooks
            // 
            this.btnAddBooks.BackColor = global::Library.Properties.Settings.Default.ButtonBlue;
            this.btnAddBooks.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Library.Properties.Settings.Default, "Button", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnAddBooks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddBooks.Location = new System.Drawing.Point(180, 83);
            this.btnAddBooks.Name = "btnAddBooks";
            this.btnAddBooks.Size = new System.Drawing.Size(171, 74);
            this.btnAddBooks.TabIndex = 5;
            this.btnAddBooks.Text = "Книги";
            this.btnAddBooks.UseVisualStyleBackColor = false;
            this.btnAddBooks.Click += new System.EventHandler(this.btnAddBooks_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Library.Properties.Settings.Default.MainColor;
            this.ClientSize = new System.Drawing.Size(721, 495);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Library.Properties.Settings.Default, "MainColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Библиотека";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuance)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvIssuance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIssuance;
        private System.Windows.Forms.DateTimePicker dtpE;
        private System.Windows.Forms.ComboBox cbBook;
        private System.Windows.Forms.ComboBox cbReader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddBooks;
        private System.Windows.Forms.Button btnAddReader;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpB;
        private System.Windows.Forms.Button btnUpd;
    }
}