using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Library
{
    static class Filler
    {
        public static void FillReaders(ComboBox cbReader) {
            string qReader = "select id_libCard from libCard";
            DataTable dtR = Queries.ExecuteReader(qReader);
            cbReader.DisplayMember = "id_libCard";
            cbReader.ValueMember = "id_libCard";
            cbReader.DataSource = dtR;
        }

        public static void FillBooks(ComboBox cbBook) {
            string qBook = "select id_booksInfo, Name from booksInfo";
            DataTable dtQ = Queries.ExecuteReader(qBook);
            cbBook.DisplayMember = "Name";
            cbBook.ValueMember = "id_booksInfo";
            cbBook.DataSource = dtQ;
        }

        public static void LoadDgv(DataGridView dgv)
        {
            string qDS = "select ib.id_issuanceBooks as id,lc.id_libCard as Билет, bi.Name as Книга, ib.BDate as Выдача, ib.EDate as Возврат, ib.Status as Статус" +
            " from issuanceBooks as ib join libCard as lc on ib.id_libCard=lc.id_libCard" +
            " join booksInfo as bi on ib.id_booksInfo=bi.id_booksInfo";
            DataTable dtDs = Queries.ExecuteReader(qDS);
            dgv.DataSource = dtDs;
        }
    }


}
