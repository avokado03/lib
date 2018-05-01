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
    public partial class UpdIssuance : Form
    {
        private int id;
        public UpdIssuance()
        {
            InitializeComponent();
        }

        public UpdIssuance(int id, int r, string b)
        {
            InitializeComponent();
            this.id = id;
            Filler.FillBooks(cbBook);
            Filler.FillReaders(cbReader);
            cbBook.Text = b;
            cbReader.Text = r.ToString();
        }

        private void btnIssuance_Click(object sender, EventArgs e)
        {
            string query = "update issuanceBooks set id_libCard = "+Convert.ToInt32(cbReader.SelectedValue)+
                ", id_booksInfo = "+Convert.ToInt32(cbBook.SelectedValue)+", BDate = '" + dtpB.Value
                + "', EDate = '" + dtpE.Value + "', Status = '" + cbStatus.Text + "' where id_issuanceBooks =" + id;
            Queries.ExecuteNonQuery(query);
            MessageBox.Show("Операция произведена успешно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы уверены, что хотите удалить запись?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string query = "delete from issuanceBooks where id_issuanceBooks =" + id;
                Queries.ExecuteNonQuery(query);
                Filler.FillBooks(cbBook);
                Filler.FillReaders(cbReader);
                MessageBox.Show("Операция произведена успешно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
