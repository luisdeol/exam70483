using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define path
            var path = @"C:\Users\luisdeolpy\Documents\Visual Studio 2015\Projects\Exam 70-483\Streams\Streams\Numbers.txt";
            //Open StreamReader using "using", so the File action thread will be finished once the job is finished.
            using (StreamReader streamReader = new StreamReader(path))
            {
                Console.WriteLine("Char by Char");
                while (!streamReader.EndOfStream)
                {
                    Console.WriteLine((char)streamReader.Read());
                }
            }
            using (StreamReader streamReader = new StreamReader(path))
            {
                Console.WriteLine("Line by Line");
                while(!streamReader.EndOfStream){
                    Console.WriteLine(streamReader.ReadLine());
                }
            }
            using (StreamReader streamReader = new StreamReader(path))
            {
                Console.WriteLine("Entire text");
                Console.WriteLine(streamReader.ReadToEnd());
            }
            Console.Read();
        }
    }
}
