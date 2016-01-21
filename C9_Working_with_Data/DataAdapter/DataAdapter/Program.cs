using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            A DataTable is similar to a DBDataReader except that it is disconnected from the Database and you can move
            the cursor back and forth. A DataSet is a container for one or more DataTables, it can also contain multiple
            resultsets returned by a SQL statement.
            The DataAdapter is the object used to populate a DataSet or DataTable and also the reconnect to the database
            to perform insert, update, or delete commands.
            */
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=LUISDEOL\\SQLEXPRESS; DATABASE=Infragistics; Integrated Security=SSPI";
            cn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.City", cn);

            DataSet ds = new DataSet();
            //It runs the query used in the SqlDataAdapter constructor to fill the DataSet
            da.Fill(ds, "dbo.City");

            cn.Close();
            /*DataSet is still available to use after the connection is closed, unlike the DBDataReader! :)
            The DataSet object has a "Table" property that you can use to reference the DataTable objects
            returned from your query. In this example only one resultset was returned, so you need to use the 0 Index
            of Tables property. DataTables has a Rows property, which contains a collection of DataRow objetcs, 
            so you can iterate over them using the foreach statement! */
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine(string.Format("Name {0} Country {1}", row["Name"], row["Country"]));
            }
        }
    }
}
