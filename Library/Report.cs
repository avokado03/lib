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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void btnIssuance_Click(object sender, EventArgs e)
        {
            if (dtpB.Value > dtpE.Value)
            {
                MessageBox.Show("Дата выбрана неверно!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
               string query = "select ib.id_issuanceBooks as id,lc.id_libCard as Билет, bi.Name as Книга, ib.BDate as Выдача, ib.EDate as Возврат, ib.Status as Статус" +
            " from issuanceBooks as ib join libCard as lc on ib.id_libCard=lc.id_libCard" +
            " join booksInfo as bi on ib.id_booksInfo=bi.id_booksInfo"+
            " where ib.BDate >= '" + dtpB.Value + "' and ib.EDate <= '" + dtpE.Value + "'";
                DataTable dt = Queries.ExecuteReader(query);
                dgvIssuance.DataSource = dt;
            }
        }
    }
}
