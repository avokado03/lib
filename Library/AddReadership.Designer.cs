namespace Library
{
    partial class AddReadership
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
            this.btnUpd = new System.Windows.Forms.Button();
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpd
            // 
            this.btnUpd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpd.BackColor = global::Library.Properties.Settings.Default.ButtonGreen;
            this.btnUpd.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Library.Properties.Settings.Default, "ButtonGreen", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnUpd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpd.Location = new System.Drawing.Point(22, 282);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(200, 42);
            this.btnUpd.TabIndex = 28;
            this.btnUpd.Text = "Изменить/удалить";
            this.btnUpd.UseVisualStyleBackColor = false;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(75, 184);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(374, 20);
            this.tbPhone.TabIndex = 27;
            // 
            // tbPN
            // 
            this.tbPN.Location = new System.Drawing.Point(307, 139);
            this.tbPN.Name = "tbPN";
            this.tbPN.Size = new System.Drawing.Size(142, 20);
            this.tbPN.TabIndex = 26;
            // 
            // tbPS
            // 
            this.tbPS.Location = new System.Drawing.Point(75, 137);
            this.tbPS.Name = "tbPS";
            this.tbPS.Size = new System.Drawing.Size(135, 20);
            this.tbPS.TabIndex = 25;
            // 
            // tbPatr
            // 
            this.tbPatr.Location = new System.Drawing.Point(75, 91);
            this.tbPatr.Name = "tbPatr";
            this.tbPatr.Size = new System.Drawing.Size(374, 20);
            this.tbPatr.TabIndex = 24;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(75, 49);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(374, 20);
            this.tbName.TabIndex = 23;
            // 
            // tbSurame
            // 
            this.tbSurame.Location = new System.Drawing.Point(75, 12);
            this.tbSurame.Name = "tbSurame";
            this.tbSurame.Size = new System.Drawing.Size(374, 20);
            this.tbSurame.TabIndex = 22;
            // 
            // btnAddRsh
            // 
            this.btnAddRsh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRsh.BackColor = global::Library.Properties.Settings.Default.ButtonRed;
            this.btnAddRsh.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Library.Properties.Settings.Default, "ButtonRed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnAddRsh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddRsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddRsh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddRsh.Location = new System.Drawing.Point(20, 220);
            this.btnAddRsh.Name = "btnAddRsh";
            this.btnAddRsh.Size = new System.Drawing.Size(429, 41);
            this.btnAddRsh.TabIndex = 21;
            this.btnAddRsh.Text = "Готово";
            this.btnAddRsh.UseVisualStyleBackColor = false;
            this.btnAddRsh.Click += new System.EventHandler(this.btnAddRsh_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(17, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Телефон";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(216, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Номер паспорта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(19, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Паспорт\r\nсерия";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(15, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(40, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = " Фамилия";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = global::Library.Properties.Settings.Default.ButtonBlue;
            this.button1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Library.Properties.Settings.Default, "ButtonBlue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(243, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 42);
            this.button1.TabIndex = 29;
            this.button1.Text = "Все билеты";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AddReadership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Library.Properties.Settings.Default.MainColor;
            this.ClientSize = new System.Drawing.Size(467, 336);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpd);
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
            this.Name = "AddReadership";
            this.Text = "Добавить читательский билет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpd;
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
        private System.Windows.Forms.Button button1;
    }
}