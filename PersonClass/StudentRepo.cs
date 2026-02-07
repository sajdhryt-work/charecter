using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PersonClass
{
    internal class StudentRepo : BaseRepo
    {
        
        public void Insert(Student student)
        {
            //       SqlCommand cmd = new SqlCommand($@"INSERT INTO [dbo].[Student]
            //      ([FirstName]
            //      ,[LastName]
            //      ,[NationalCode]
            //      ,[StudentCode])
            //VALUES
            //      ('{student.FirstName}'
            //      ,'{student.LastName}'
            //      ,'{student.NationalId}'
            //      ,'{student.StudentCode}')");             

            SqlCommand cmd = new SqlCommand(@"dbo.InsertStudent");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
            cmd.Parameters.AddWithValue("@LastName", student.LastName);
            cmd.Parameters.AddWithValue("@NationalCode", student.NationalId);
            cmd.Parameters.AddWithValue("@StudentCode", student.StudentCode);
            Execute(cmd);

        }
        public void Update(Student student)
        {
           
            SqlCommand cmd = new SqlCommand($@"UPDATE [dbo].[Student]
   SET [FirstName] = '{student.FirstName}'
      ,[LastName] = '{student.LastName}'
      ,[NationalCode] = '{student.NationalId}'
      ,[StudentCode] = '{student.StudentCode}'
 WHERE '{student.Id}'");

            Execute(cmd);
        }
        public void Delete(int id)
        {
            SqlCommand cmd = new SqlCommand($@"DELETE FROM [dbo].[Student]
             WHERE Id = {id}");
            Execute(cmd);

        }
        public DataTable Select(int id =0)
        {
            string cs = "Data Source =.; Initial Catalog = School; Integrated Security = True;";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand($@"SELECT * FROM dbo.Student WHERE {id}=0 or Id = {id}");
            cmd.Connection = con;
            var dt = new DataTable();
            try
            {
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch { System.Windows.Forms.MessageBox.Show("Error"); }

            con.Close();
            return dt;

        }
        public DataTable Select(string search)
        {
            string cs = "Data Source =.; Initial Catalog = School; Integrated Security = True;";
            SqlConnection con = new SqlConnection(cs);

            con.Open();
            SqlCommand cmd = new SqlCommand($@"SELECT * FROM dbo.Student WHERE FirstName like N'%{search}%' or LastName like N'%{search}%'");
            cmd.Connection = con;
            var dt = new DataTable();
            try
            {
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch { System.Windows.Forms.MessageBox.Show("Error"); }

            con.Close();
            return dt;

        }
    }
}
