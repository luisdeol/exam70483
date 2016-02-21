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

            //You can also order by more than one property by separating your conditions with a comma.
            List<Hometown> hometowns = new List<Hometown>()
             {
                new Hometown() { City = "Philadelphia", State = "PA" },
                new Hometown() { City = "Ewing", State = "NJ" },
                new Hometown() { City = "Havertown", State = "PA" },
                new Hometown() { City = "Fort Washington", State = "PA" },
                new Hometown() { City = "Trenton", State = "NJ" }
            };
            var orderedHometowns = from h in hometowns
                                   orderby h.State ascending, h.City descending
                                   select h;
        }
        class Hometown
        {
            public string City { get; set; }
            public string State { get; set; }
        }
    }
}
