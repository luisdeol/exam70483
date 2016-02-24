using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Queries_FIltering
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Method-based queries are actually extension methods found in the System.Linq namespace and 
            take a lambda expression as a parameter, which represents the logic
            to be performed while enumerating through the sequence.
            Let's do the same query we did before (which was created using query expression) using Method-based queries
            */
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /*We can use a Where clause chain (second following line) or the && word (first following line)*/
            var evenNumbers = myArray.Where(i => i % 2 == 0 && i > 5);
            var evenNumbersWhereChain = myArray.Where(i => i % 2 == 0).Where(i => i > 5);
            
            foreach(var even in evenNumbers)
            {
                Console.WriteLine(even);
            }
            foreach (var even in evenNumbersWhereChain)
            {
                Console.WriteLine(even);
            }
            /*We receive the same result!  */
        }
    }
}
