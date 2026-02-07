using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    internal abstract class BaseRepo
    {
        string cs = "Data Source =.; Initial Catalog = School; Integrated Security = True;";
        SqlConnection con;
        public BaseRepo()
        {
            con = new SqlConnection(cs);
        }
        protected void Execute(SqlCommand cmd)
        {
            con.Open();
            cmd.Connection = con;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch { System.Windows.Forms.MessageBox.Show("Error"); }
            con.Close();
        }
    }
}
