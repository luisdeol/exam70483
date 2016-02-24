using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_And_QueryExpression_Projection
{
    class Program
    {
        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string State { get; set; }
        }
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>()
            {
                new Person() { FirstName = "Luis", LastName = "Oliveira", State = "RN" },
                new Person() { FirstName = "John", LastName = "Smith", State = "Madrid" }
            };
            /*Using Query Expressions! */
            var lastNameQR = from p in persons
                             select p.LastName;
            /* Using Method-based expression*/
            var lastNameMethodBased = persons.Select(p => p.LastName);

            Console.WriteLine("Using Query Expression: ");
            foreach (var lastName in lastNameQR)
            {
                Console.WriteLine(String.Format("Last Name: {0}", lastName));
            }
            Console.WriteLine("Using Method-Based Expression");
            foreach (var lastName in lastNameMethodBased)
            {
                Console.WriteLine(String.Format("Last Name: {0}", lastName));
            }
        }
    }
}
