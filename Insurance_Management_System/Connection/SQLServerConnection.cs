using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.SqlClient;  // Data Provider for SQL Server
using System.Windows.Forms; // Contains classes for creating Windows-based applications that 
                           //take full advantage of the rich user interface features available 
                           //in the Microsoft Windows operating system.

namespace Insurance_Management_System.Connection
{
    class SQLServerConnection
    {
        public static string stringConnection = "";

        public static DataTable executeSQL(string sql)
        {
            SqlCommand command;
            SqlConnection connection = new SqlConnection();
            SqlDataAdapter adapter = default(SqlDataAdapter);
            DataTable dt = new DataTable();

            try
            {
                connection.ConnectionString = stringConnection;
                connection.Open();

                adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(dt);


                connection.Close();
                connection = null;
                return dt;

            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("An error occured: " + ex.Message,
                    "SQL Server Connection Failed " + MessageBoxButtons.OK);
                dt = null;
            }
            return dt;
        }

        /*protected SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = stringConnection;
            return con;
        }
        */
        /*public void setData(String query, String msg)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill

        }
        */
        /*protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-O3H1CKS\\SQLCS412_SOFIA;Initial Catalog = InsuranceDatabase;Integrated Security=True";
            return con;
        }

        public DataSet getData(String query)
        {
            SqlConnection con = getConnection
        }*/
    }
}
