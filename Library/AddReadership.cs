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
    public partial class AddReadership : Form
    {
        public AddReadership()
        {
            InitializeComponent();
        }

        private void btnAddRsh_Click(object sender, EventArgs e)
        {
            string sname, name, patr, ps, pn, phone;
            try
            {
                sname = tbSurame.Text;
                name = tbName.Text;
                patr = tbPatr.Text;
                ps = tbPS.Text;
                pn = tbPN.Text;
                phone = tbPhone.Text;
                Queries.ExecuteNonQuery("insert into libCard values ('" +
                    sname + "', '" + name + "', '" + patr + "', '" + ps + "', '" + pn + "', '" + phone+"')");
                MessageBox.Show("Операция произведена успешно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            UpdReadersheep ur = new UpdReadersheep();
            ur.ShowDialog();
        }

    }
}
