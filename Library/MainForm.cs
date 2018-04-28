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
            cbBook.Refresh();
            cbReader.Refresh();
            dgvIssuance.Refresh();
            string qReader = "select id_libCard from libCard";
            DataTable dtR = Queries.ExecuteReader(qReader);
            cbReader.DisplayMember = "id_libCard";
            cbReader.ValueMember = "id_libCard";
            cbReader.DataSource = dtR;

            string qBook = "select id_booksInfo, Name from booksInfo";
            DataTable dtQ = Queries.ExecuteReader(qBook);
            cbBook.DisplayMember = "Name";
            cbBook.ValueMember = "id_booksInfo";
            cbBook.DataSource = dtQ;

            string qDS = "select lc.id_libCard as Билет, bi.Name as Книга, ib.BDate as Выдача, ib.EDate as Возврат, ib.Status as Статус" +
                        " from issuanceBooks as ib join libCard as lc on ib.id_libCard=lc.id_libCard"+
                        " join booksInfo as bi on ib.id_booksInfo=bi.id_booksInfo";
            DataTable dtDs = Queries.ExecuteReader(qDS);
            dgvIssuance.DataSource = dtDs;

            DataGridViewButtonColumn dgvbc = new DataGridViewButtonColumn();
            dgvbc.Name = "dgvbc";
            dgvbc.HeaderText = "";
            dgvbc.Text = "Edit";
            dgvbc.UseColumnTextForButtonValue = true;
            dgvbc.Width = 45;
            dgvIssuance.Columns.Add(dgvbc);

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
