using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryExpressions_Etc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Filtering, you can add multiple where clauses in the Query Expression
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = from i in myArray
                              where i % 2 == 0
                              where i > 5
                              select i;
            foreach (int i in evenNumbers)
                Console.WriteLine(i.ToString());
            //Ordering
            var evenNumbers2 = from i in myArray
                               where i % 2 == 0
                               orderby i descending
                               select i;
        }
    }
}
