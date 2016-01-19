using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StringReader_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StringReader stringReader = new StringReader("Hello\nGoodbye"))
            {
                int pos = stringReader.Read();
                while (pos != -1)
                {
                    Console.WriteLine("{0}", (char)pos);
                    pos = stringReader.Read();
                }
            }
            Console.Read();   
        }
    }
}
