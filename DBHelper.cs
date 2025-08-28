using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionariaApp
{
    public class DBHelper
    {
        private static string connectionString =
            "Data Source=PC-NAS,1433;Initial Catalog=Concesionaria_DB;User ID=sa;Password=Panuelo81;Persist Security Info=True;Max Pool Size=200;MultipleActiveResultSets=True;Connect Timeout=30;Connection Lifetime=300;";
        //"data source=localhost\\SQLEXPRESS;Initial Catalog=Concesionaria_DB;Integrated Security = True;";

        public static DataTable GetTable(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static int Execute(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
