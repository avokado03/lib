namespace Library
{
    partial class UpdReadersheep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdReadersheep));
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbPN = new System.Windows.Forms.TextBox();
            this.tbPS = new System.Windows.Forms.TextBox();
            this.tbPatr = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurame = new System.Windows.Forms.TextBox();
            this.btnAddRsh = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbReader = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bntDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(76, 245);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(374, 20);
            this.tbPhone.TabIndex = 40;
            // 
            // tbPN
            // 
            this.tbPN.Location = new System.Drawing.Point(308, 200);
            this.tbPN.Name = "tbPN";
            this.tbPN.Size = new System.Drawing.Size(142, 20);
            this.tbPN.TabIndex = 39;
            // 
            // tbPS
            // 
            this.tbPS.Location = new System.Drawing.Point(76, 198);
            this.tbPS.Name = "tbPS";
            this.tbPS.Size = new System.Drawing.Size(135, 20);
            this.tbPS.TabIndex = 38;
            // 
            // tbPatr
            // 
            this.tbPatr.Location = new System.Drawing.Point(76, 152);
            this.tbPatr.Name = "tbPatr";
            this.tbPatr.Size = new System.Drawing.Size(374, 20);
            this.tbPatr.TabIndex = 37;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(76, 110);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(374, 20);
            this.tbName.TabIndex = 36;
            // 
            // tbSurame
            // 
            this.tbSurame.Location = new System.Drawing.Point(76, 73);
            this.tbSurame.Name = "tbSurame";
            this.tbSurame.Size = new System.Drawing.Size(374, 20);
            this.tbSurame.TabIndex = 35;
            // 
            // btnAddRsh
            // 
            this.btnAddRsh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRsh.BackColor = global::Library.Properties.Settings.Default.ButtonGreen;
            this.btnAddRsh.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Library.Properties.Settings.Default, "ButtonGreen", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnAddRsh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddRsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddRsh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddRsh.Location = new System.Drawing.Point(14, 281);
            this.btnAddRsh.Name = "btnAddRsh";
            this.btnAddRsh.Size = new System.Drawing.Size(217, 41);
            this.btnAddRsh.TabIndex = 34;
            this.btnAddRsh.Text = "Обновить";
            this.btnAddRsh.UseVisualStyleBackColor = false;
            this.btnAddRsh.Click += new System.EventHandler(this.btnAddRsh_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(18, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Телефон";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(217, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Номер паспорта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(20, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 26);
            this.label4.TabIndex = 31;
            this.label4.Text = "Паспорт\r\nсерия";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(16, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(41, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(11, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = " Фамилия";
            // 
            // cbReader
            // 
            this.cbReader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbReader.FormattingEnabled = true;
            this.cbReader.Location = new System.Drawing.Point(76, 36);
            this.cbReader.Name = "cbReader";
            this.cbReader.Size = new System.Drawing.Size(374, 21);
            this.cbReader.TabIndex = 41;
            this.cbReader.Text = "Читательский билет";
            this.cbReader.SelectedIndexChanged += new System.EventHandler(this.cbReader_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(33, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Билет";
            // 
            // bntDel
            // 
            this.bntDel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bntDel.BackColor = global::Library.Properties.Settings.Default.ButtonRed;
            this.bntDel.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Library.Properties.Settings.Default, "ButtonRed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.bntDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bntDel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntDel.Location = new System.Drawing.Point(237, 281);
            this.bntDel.Name = "bntDel";
            this.bntDel.Size = new System.Drawing.Size(233, 41);
            this.bntDel.TabIndex = 43;
            this.bntDel.Text = "Удалить";
            this.bntDel.UseVisualStyleBackColor = false;
            this.bntDel.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdReadersheep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Library.Properties.Settings.Default.MainColor;
            this.ClientSize = new System.Drawing.Size(477, 355);
            this.Controls.Add(this.bntDel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbReader);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbPN);
            this.Controls.Add(this.tbPS);
            this.Controls.Add(this.tbPatr);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSurame);
            this.Controls.Add(this.btnAddRsh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Library.Properties.Settings.Default, "MainColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdReadersheep";
            this.Text = "Изменить читательский билет";
            this.Load += new System.EventHandler(this.UpdReadersheep_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbPN;
        private System.Windows.Forms.TextBox tbPS;
        private System.Windows.Forms.TextBox tbPatr;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurame;
        private System.Windows.Forms.Button btnAddRsh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbReader;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bntDel;
    }
}