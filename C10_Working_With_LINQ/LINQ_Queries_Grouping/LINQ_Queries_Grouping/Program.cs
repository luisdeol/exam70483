using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Queries_Grouping
{
    class Program
    {
        class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string StateName { get; set; }
        }

        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    FirstName = "Luis",
                    LastName = "Felipe",
                    StateName = "SP"
                },
                new Employee()
                {
                    FirstName = "John",
                    LastName = "Smith",
                    StateName = "Madrid"
                }
            };

            var employeesByState = employees.GroupBy(e => e.StateName);
            
            foreach (var employeeGroup in employeesByState)
            {
                Console.WriteLine(String.Format("{0} : {1}", employeeGroup.Key, employeeGroup.Count()));
                foreach (var employee in employeeGroup)
                {
                    Console.WriteLine(String.Format("{0} , {1}", employee.LastName, employee.StateName));
                }
            }
        }
    }
}
