using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem
{
    class DAL
    {
        public static SqlCommand cmd;         
        public static string query = string.Empty;
        public static SqlConnection baglanti;
        public static string conn = "Data Source=.;Initial Catalog= StudentInformationSystem;Integrated Security=true;";


        internal static DataTable Select(string sql, params object[] values)
        {
            baglanti = new SqlConnection(conn);
            baglanti.Open();
            query = sql;
            cmd = new SqlCommand(query, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            for (int i = 0; i < values.Length; i++)
            {
                cmd.Parameters.AddWithValue("@" + (i + 1), values[i]);
            }

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }


       
    }
}
