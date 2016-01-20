using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExecuteXmlReader
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=LUISDEOL\\SQLEXPRESS;Database=Infragistics;Integrated Security=SSPI;";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM dbo.City FOR XML AUTO XMLDATA";
            System.Xml.XmlReader xml = cmd.ExecuteXmlReader();

            cn.Close();
        }
    }
}
