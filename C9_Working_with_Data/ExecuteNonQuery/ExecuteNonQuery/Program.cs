using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteNonQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The ExecuteNonQuery method is used to execute statements against the database that do not return
            resultsets.For example, an insert, update, or delete statement does not return any records.They simply
            execute the statement against a table.
            Creating the SqlConnection*/
            SqlConnection cn = new SqlConnection();
            /*I use the Windows Authentication to have access to SQL Server. If you don't use it, your 
            connection string should be something like "Server=<ServerName>; Database=<DatabaseName>; User id=<id>;
            Password=<password>;";*/
            cn.ConnectionString = "Server=LUISDEOL\\SQLEXPRESS; Database=Infragistics; Integrated Security=SSPI;";
            cn.Open();

            //Create a SqlCommand object, which represents a Transact-SQL-Statement to execute against against your SQL 
            //database
            SqlCommand cmd = new SqlCommand();
            //You need to define these three properties to be able to execute commands against the SQL Database
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO dbo.City VALUES ('Madrid', 'Espanha')";
            //Execute the NonQuery and close the SqlConnection cn
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
