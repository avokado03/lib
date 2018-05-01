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
    public partial class UpdForm : Form
    {
        private DateTime y;
        private string Ins;
        public UpdForm()
        {
            InitializeComponent();
            Filler.FillBooks(cbBook);
        }

        private void UpdForm_Load(object sender, EventArgs e)
        {
        }

        private void cbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(cbBook.SelectedValue);
            DataTable dt = Queries.ExecuteReader("select * from booksInfo where id_booksInfo =" + bookId);
            if (dt != null) {
                tbName.Text = dt.Rows[0][1].ToString();
                tbAutor.Text = dt.Rows[0][2].ToString();
                tbPubl.Text = dt.Rows[0][3].ToString();
                y = Convert.ToDateTime(dt.Rows[0][4].ToString());
                tbYear.Text = y.Year.ToString();
                Ins = dt.Rows[0][7].ToString();
                tbPage.Text = dt.Rows[0][5].ToString();
                tbIns.Text = Ins;
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string name, autor, publ, year;
            int pc, inst;
            try
            {
                name = tbName.Text;
                autor = tbAutor.Text;
                publ = tbPubl.Text;
                year = tbYear.Text + "-01-01";
                DateTime y = Convert.ToDateTime(year);
                pc = Convert.ToInt32(tbPage.Text);
                inst = Convert.ToInt32(tbIns.Text);
                int newI = Convert.ToInt32(Ins) - inst;
                string query = "update booksInfo set Name ='" + name + 
                    "', Autor='" + autor + "', Publishing='" + publ + "', Year='" + y + "', PageCount =" + pc 
                    + ", Count = Count + " + newI + ", Instance =" + inst+ " where id_booksInfo ="+Convert.ToInt32(cbBook.SelectedValue);
                Queries.ExecuteNonQuery(query);
                MessageBox.Show("Операция произведена успешно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы уверены, что хотите удалить запись? Все связанные с ней операции будут удалены", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string query = "delete from booksInfo where id_booksInfo =" + Convert.ToInt32(cbBook.SelectedValue);
                Queries.ExecuteNonQuery(query);
                MessageBox.Show("Операция произведена успешно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Filler.FillBooks(cbBook);
            }
        }
    }
}
