using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            Filler.FillReaders(cbReader);
            Filler.FillBooks(cbBook);
            Filler.LoadDgv(dgvIssuance);
            DataGridViewButtonColumn dgvbc = new DataGridViewButtonColumn();
            dgvbc.Name = "dgvbc";
            dgvbc.HeaderText = "Изменить";
            dgvbc.Text = "Выбрать";
            dgvbc.UseColumnTextForButtonValue = true;
            dgvbc.DefaultCellStyle.SelectionBackColor = Properties.Settings.Default.ButtonBlue;
            dgvbc.DefaultCellStyle.BackColor = Properties.Settings.Default.ButtonGreen;
            dgvIssuance.Columns.Add(dgvbc);

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIssuance_Click(object sender, EventArgs e)
        {
            int libCard, book;
            DateTime begin, end;
            string status = "Выдано";
            begin = dtpB.Value;
            end = dtpE.Value;
            if (begin > end)
                MessageBox.Show("Дата выбрана неверно!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else {
                libCard = Convert.ToInt32(cbReader.SelectedValue);
                book = Convert.ToInt32(cbBook.SelectedValue);
                string qCount = "select Count from booksInfo where id_booksInfo=" + book;
                int c = Queries.ExecuteReader(qCount,0);
                if (c > 0) { 
                    string qIss = "insert into issuanceBooks values (" + libCard + ", " + book + ", '" + 
                        begin + "', '" + end + "', '" + status + "')";
                    string qInst = "update booksInfo set Count = Count-1 where id_booksInfo=" + book;
                    Queries.ExecuteNonQuery(qIss);
                    Queries.ExecuteNonQuery(qInst);
                    Filler.LoadDgv(dgvIssuance);
                    MessageBox.Show("Операция произведена успешно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Книги нет в наличии или она удалена из библиофонда!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            AddBook ab = new AddBook();
            ab.ShowDialog();
        }

        private void dgvIssuance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.ColumnIndex.ToString());
            try
            {
                if (e.ColumnIndex == 0)
                {
                    int id = Convert.ToInt32(dgvIssuance.Rows[e.RowIndex].Cells[1].Value);
                    int idR = Convert.ToInt32(dgvIssuance.Rows[e.RowIndex].Cells[2].Value);
                    string book = Convert.ToString(dgvIssuance.Rows[e.RowIndex].Cells[3].Value);
                    UpdIssuance ui = new UpdIssuance(id, idR, book);
                    ui.ShowDialog();
                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filler.LoadDgv(dgvIssuance);
            Filler.FillBooks(cbBook);
            Filler.FillReaders(cbReader);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.ShowDialog();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Information i = new Information();
            i.ShowDialog();
        }

        private void btnAddReader_Click(object sender, EventArgs e)
        {
            AddReadership ar = new AddReadership();
            ar.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
