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
            cbBook.Text = b;
            cbReader.Text = r.ToString();
            cbBook.Enabled = false;
            cbReader.Enabled = false;
        }

        private void btnIssuance_Click(object sender, EventArgs e)
        {
            string query = "update issuanceBooks set BDate = '" + dtpB.Value
                + "', EDate = '" + dtpE.Value + "', Status = '" + cbStatus.Text + "' where id_issuanceBooks =" + id;
            Queries.ExecuteNonQuery(query);
            MessageBox.Show("Операция произведена успешно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
