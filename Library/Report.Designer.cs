namespace Library
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvIssuance = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIssuance = new System.Windows.Forms.Button();
            this.dtpE = new System.Windows.Forms.DateTimePicker();
            this.dtpB = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuance)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvIssuance, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(658, 384);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.dgvIssuance.Size = new System.Drawing.Size(652, 224);
            this.dgvIssuance.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnIssuance);
            this.groupBox1.Controls.Add(this.dtpE);
            this.groupBox1.Controls.Add(this.dtpB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(3, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите диапазон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "До";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "От";
            // 
            // btnIssuance
            // 
            this.btnIssuance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIssuance.BackColor = global::Library.Properties.Settings.Default.ButtonBlue;
            this.btnIssuance.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Library.Properties.Settings.Default, "ButtonBlue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnIssuance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIssuance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIssuance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIssuance.Location = new System.Drawing.Point(9, 90);
            this.btnIssuance.Name = "btnIssuance";
            this.btnIssuance.Size = new System.Drawing.Size(637, 43);
            this.btnIssuance.TabIndex = 4;
            this.btnIssuance.Text = "Сформировать отчет";
            this.btnIssuance.UseVisualStyleBackColor = false;
            this.btnIssuance.Click += new System.EventHandler(this.btnIssuance_Click);
            // 
            // dtpE
            // 
            this.dtpE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpE.CalendarTitleBackColor = global::Library.Properties.Settings.Default.ButtonBlue;
            this.dtpE.DataBindings.Add(new System.Windows.Forms.Binding("CalendarTitleBackColor", global::Library.Properties.Settings.Default, "ButtonBlue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dtpE.Location = new System.Drawing.Point(36, 56);
            this.dtpE.Name = "dtpE";
            this.dtpE.Size = new System.Drawing.Size(606, 20);
            this.dtpE.TabIndex = 3;
            // 
            // dtpB
            // 
            this.dtpB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpB.CalendarTitleBackColor = global::Library.Properties.Settings.Default.ButtonBlue;
            this.dtpB.DataBindings.Add(new System.Windows.Forms.Binding("CalendarTitleBackColor", global::Library.Properties.Settings.Default, "ButtonBlue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dtpB.Location = new System.Drawing.Point(36, 30);
            this.dtpB.Name = "dtpB";
            this.dtpB.Size = new System.Drawing.Size(607, 20);
            this.dtpB.TabIndex = 2;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Library.Properties.Settings.Default.MainColor;
            this.ClientSize = new System.Drawing.Size(658, 384);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Library.Properties.Settings.Default, "MainColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report";
            this.Text = "Движение книг";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuance)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvIssuance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpE;
        private System.Windows.Forms.DateTimePicker dtpB;
        private System.Windows.Forms.Button btnIssuance;
    }
}