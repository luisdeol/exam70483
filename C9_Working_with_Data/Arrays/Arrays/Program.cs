using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*An array is the most basic type used to store a set of data. It contains elements which are
            referenced by their index using square brackets, [].
            Remember, when you create an array you MUST specify the number of elements the array can contain. 
            Arrays in C# are zero based, so the first element has the index 0! */
            string[] myArray = new string[2];
            myArray[0] = "First element";
            myArray[1] = "Second element";
            /* You can create a multidimensional array using the syntax 
            <type>[,] array_name = new <type>[num_rows, num_columns]*/
            int[,] myMultDimArray = new int[2, 2];
            myMultDimArray[0, 0] = 1;
            myMultDimArray[0, 1] = 2;
            myMultDimArray[1, 0] = 3;
            myMultDimArray[1, 1] = 4;
            /*The two most commonly used properties of an array are Length and Rank. Length represents the total number
            of elements in all dimensions of the array, and Rank indicates the number of dimension in the array*/
            Console.WriteLine(myMultDimArray.Length.ToString()); //Returns 4
            Console.WriteLine(myMultDimArray.Rank.ToString()); //Returns 2
        }
    }
}
