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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string name, autor, publ, year;
            int pc,inst;
            try
            {
                name = tbName.Text;
                autor = tbAutor.Text;
                publ = tbPubl.Text;
                year = tbYear.Text + "-01-01";
                DateTime y = Convert.ToDateTime(year);
                pc = Convert.ToInt32(tbPage.Text);
                inst = Convert.ToInt32(tbIns.Text);
                string query = "insert into booksInfo values ('" + name +
                    "', '" + autor + "', '" + publ + "', '" + y + "', " + pc + ", " + inst +", "+inst+ ")";
                Queries.ExecuteNonQuery(query);
                MessageBox.Show("Операция произведена успешно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            UpdForm uf = new UpdForm();
            uf.ShowDialog();
        }

    }
}
