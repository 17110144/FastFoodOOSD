using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace FastFood.BusinessLayer
{
    class cls_Database
    {
        public static SqlConnection conn = new SqlConnection("Data Source=hoangphan\\hoangphan;Initial Catalog=FASTFOOD;Integrated Security=True");

        public static void connectSQL()
        {
            try
            {
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message);
            }
        }
        public static void disconnectSQL()
        {
            try
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message);
            }
        }
        //ham doc table
        public static DataTable TableRead(string query)
        {
            connectSQL();
            DataTable dt = new DataTable();
            SqlDataAdapter dbA = new SqlDataAdapter(query, conn);
            dbA.Fill(dt);
            dbA.Dispose();
            disconnectSQL();
            return dt;
        }
        //ham them, xoa, sua
        public static void AED(string query)
        {
            connectSQL();
            SqlCommand command = new SqlCommand(query, conn);
            command.ExecuteNonQuery();
            command.Dispose();
            disconnectSQL();
        }

    }
}
