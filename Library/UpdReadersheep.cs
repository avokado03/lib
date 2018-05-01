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
    public partial class UpdReadersheep : Form
    {
        public UpdReadersheep()
        {
            InitializeComponent();
            Filler.FillReaders(cbReader);
        }

        private void UpdReadersheep_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           DialogResult dr = MessageBox.Show("Вы уверены, что хотите удалить запись? Все связанные с ней операции будут удалены", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) {
                string query = "delete from libCard where id_libCard =" + Convert.ToInt32(cbReader.SelectedValue);
                Queries.ExecuteNonQuery(query);
                MessageBox.Show("Операция произведена успешно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Filler.FillReaders(cbReader);
            }

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
                Queries.ExecuteNonQuery("update libCard set Surname='" +
                    sname + "', Name='" + name + "', Patronymic='" + patr + "', PassSeries='" + ps 
                    + "', PassNumber='" + pn + "', Phone='" + phone + "' where id_libCard ="+Convert.ToInt32(cbReader.SelectedValue));
                MessageBox.Show("Операция произведена успешно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbReader_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from libCard where id_libCard =" + Convert.ToInt32(cbReader.Text);
            DataTable dt = Queries.ExecuteReader(query);
            tbSurame.Text = dt.Rows[0][1].ToString();
            tbName.Text = dt.Rows[0][2].ToString();
            tbPatr.Text = dt.Rows[0][3].ToString();
            tbPS.Text = dt.Rows[0][4].ToString();
            tbPN.Text = dt.Rows[0][5].ToString();
            tbPhone.Text = dt.Rows[0][6].ToString();
        }
    }
}
