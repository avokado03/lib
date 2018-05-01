namespace Library
{
    partial class AddBook
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbPubl = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbPage = new System.Windows.Forms.TextBox();
            this.tbIns = new System.Windows.Forms.TextBox();
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnBookList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(55, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Автор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Издательство";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(43, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Год\r\nиздания";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(239, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Кол-во страниц";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(13, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Кол-во \r\nэкземпляров";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBook.BackColor = global::Library.Properties.Settings.Default.ButtonRed;
            this.btnAddBook.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Library.Properties.Settings.Default, "ButtonRed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddBook.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddBook.Location = new System.Drawing.Point(16, 225);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(445, 41);
            this.btnAddBook.TabIndex = 7;
            this.btnAddBook.Text = "Готово";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(98, 10);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(363, 20);
            this.tbName.TabIndex = 8;
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(98, 47);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(363, 20);
            this.tbAutor.TabIndex = 9;
            // 
            // tbPubl
            // 
            this.tbPubl.Location = new System.Drawing.Point(98, 89);
            this.tbPubl.Name = "tbPubl";
            this.tbPubl.Size = new System.Drawing.Size(363, 20);
            this.tbPubl.TabIndex = 10;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(98, 135);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(135, 20);
            this.tbYear.TabIndex = 11;
            // 
            // tbPage
            // 
            this.tbPage.Location = new System.Drawing.Point(330, 137);
            this.tbPage.Name = "tbPage";
            this.tbPage.Size = new System.Drawing.Size(131, 20);
            this.tbPage.TabIndex = 12;
            // 
            // tbIns
            // 
            this.tbIns.Location = new System.Drawing.Point(98, 182);
            this.tbIns.Name = "tbIns";
            this.tbIns.Size = new System.Drawing.Size(363, 20);
            this.tbIns.TabIndex = 13;
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
            this.btnUpd.Location = new System.Drawing.Point(16, 282);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(217, 42);
            this.btnUpd.TabIndex = 14;
            this.btnUpd.Text = "Изменить/удалить";
            this.btnUpd.UseVisualStyleBackColor = false;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // btnBookList
            // 
            this.btnBookList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBookList.BackColor = global::Library.Properties.Settings.Default.ButtonBlue;
            this.btnBookList.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Library.Properties.Settings.Default, "ButtonBlue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnBookList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBookList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBookList.Location = new System.Drawing.Point(244, 282);
            this.btnBookList.Name = "btnBookList";
            this.btnBookList.Size = new System.Drawing.Size(217, 42);
            this.btnBookList.TabIndex = 15;
            this.btnBookList.Text = "Библиофонд";
            this.btnBookList.UseVisualStyleBackColor = false;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Library.Properties.Settings.Default.MainColor;
            this.ClientSize = new System.Drawing.Size(473, 336);
            this.Controls.Add(this.btnBookList);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.tbIns);
            this.Controls.Add(this.tbPage);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbPubl);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Library.Properties.Settings.Default, "MainColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddBook";
            this.Text = "Добавить книгу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbPubl;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbPage;
        private System.Windows.Forms.TextBox tbIns;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Button btnBookList;
    }
}