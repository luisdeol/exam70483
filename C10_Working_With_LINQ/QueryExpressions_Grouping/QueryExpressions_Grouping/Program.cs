using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryExpressions_Grouping
{
    class Program
    {
        class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        static void Main(string[] args)
        {
            //You can use the group clause in a query expression to group by a particular property to accomplish this requirement.
            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    FirstName = "Luis",
                    LastName = "Felipe"
                },
                new Employee()
                {
                    FirstName = "John",
                    LastName = "Smith"
                }
            };
            var employeeByFirstName = from e in employees
                                      group e by e.FirstName;

            foreach (var employeeGroup in employeeByFirstName)
            {
                Console.WriteLine(employeeGroup.Key + " : " + employeeGroup.Count());
                foreach (var employee in employeeGroup)
                {
                    Console.WriteLine(employee.LastName + ", " + employee.FirstName);
                }
            }
        }
    }
}
