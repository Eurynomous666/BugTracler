using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Bug_Tracker
{
    class Connection
    {
        SqlConnection cn = new SqlConnection(@"Data Source=LENOVO-PC;Initial Catalog=BUG;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        // For insert update and delete Statement
        public void manipulate(string query)
        {
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        // For Select Statement
        public DataTable retrieve(string query)
        {
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(query, cn);
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}
