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
    static class Queries
    {
        private static string cs = Properties.Settings.Default.Cs;

        public static void ExecuteNonQuery(string query)
        {
            using (SqlConnection c = new SqlConnection(cs))
            {
                try
                {
                    c.Open();
                    SqlCommand cmd = new SqlCommand(query, c);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Операция произведена успешно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    c.Close();
                }
            }
        }

        public static DataTable ExecuteReader(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection c = new SqlConnection(cs))
            {
                try
                {
                    c.Open();
                    SqlCommand cmd = new SqlCommand(query, c);
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                finally
                {
                    c.Close();
                }
            }
        }
    }
}
