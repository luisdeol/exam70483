using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*LINQ query expressions enable you to perform “queries” against the array with syntax 
            similar to SQL except it is C# syntax and the order of the elements is different. 
            The benefit of a query expression is less coding and more readability.*/
            int[] myArray = new int[10] { 1,2,3,4,5,6,7,8,9,10};
            var evenNumbers = from i in myArray
                              where i % 2 == 0
                              select i;
            foreach (int i in evenNumbers)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
