using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExecuteReader
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = "Server=LUISDEOL\\SQLEXPRESS; Database=Infragistics; Integrated Security=SSPI;";
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM dbo.City";
                /*Use the ExecuteReader method to retrieve results from the database such as when you use a
                Select statement. The ExecuteReader returns a DBDataReader object which is 
                a forward-only resultset that remains connected to the database the entire time the reader is open.*/
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Console.WriteLine(string.Format("Name: {0} , Country: {1}", dr["Name"], dr["Country"]));
                    }
                }
                dr.Close();
            }
            Console.Read();
        }
    }
}
