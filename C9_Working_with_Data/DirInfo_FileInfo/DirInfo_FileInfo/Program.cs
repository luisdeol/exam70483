using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirInfo_FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir_Info = new DirectoryInfo(@"C:\");
            Console.WriteLine("Files: ");
            foreach (FileInfo fileInfo in dir_Info.GetFiles())
            {
                Console.WriteLine(fileInfo.Name);
            }
            Console.WriteLine("Directories: ");
            foreach(DirectoryInfo directoryInfo in dir_Info.GetDirectories())
            {
                Console.WriteLine(directoryInfo.Name);
            }
            Console.Read();
        }
    }
}
