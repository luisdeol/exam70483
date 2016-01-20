using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExecuteScalar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The ExecuteScalar method is used when you know that your resultset contains only a single
            column with a single row. This is great when your query returns the result of an aggregate function
            such as SUM or AVG.*/

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=LUISDEOL\\SQLEXPRESS; Database=Infragistics; Integrated Security=SSPI;";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT COUNT(*) FROM dbo.City";
            //The ExecuteScalar method always returns an object! 
            object obj = cmd.ExecuteScalar();
            Console.WriteLine(string.Format("Count {0}", obj.ToString()));
            cn.Close();
        }
    }
}
