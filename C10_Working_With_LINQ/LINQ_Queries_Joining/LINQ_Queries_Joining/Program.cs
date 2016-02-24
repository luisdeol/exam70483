using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Queries_Joining
{
    class Program
    {
        class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int StateId { get; set; }
        }
        class State
        {
            public int StateId { get; set; }
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
                    StateId = 1
                },
                new Employee()
                {
                    FirstName = "John",
                    LastName = "Smith",
                    StateId = 2
                },
                new Employee()
                {
                    FirstName = "Deadpool",
                    LastName = "NULL!",
                    StateId = 1
                }
            };

            List<State> states = new List<State>()
            {
                new State()
                {
                    StateId = 1,
                    StateName = "RN"
                },
                new State()
                {
                    StateId = 2,
                    StateName = "SP"
                } };

            /* The parameters of the Join method are a collection that implements IEnumerable interface, 
            the following keys of each group you want to match, then the condition match (attribute1, attribute2)
            in a lambda expression of a new created object with attributes from both matched "rows" */
            var employeeByState = employees.Join(states,
                                                 e => e.StateId,
                                                 s => s.StateId,
                                                 (e, s) => new { e.LastName, s.StateName });
            foreach (var employee in employeeByState)
            {
                Console.WriteLine(String.Format("Last Name: {0}, State Name: {1}", employee.LastName, employee.StateName));
            }
        }
    }
}
