using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryExpressions_Joining
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
            /*You can use the join clause to combine two or more sequences of objects similar to how you join
            tables in a SQL statement!*/
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

            //The join clause must use the equals keyword, not the = operator

            var employeeByState = from e in employees
                                  join s in states
                                  on e.StateId equals s.StateId
                                  select new { e.LastName, s.StateName };

            // Outer Join
            var employeeByStateOJ = from e in employees
                                    join s in states
                                    on e.StateId equals s.StateId into employeeGroup
                                    from item in employeeGroup.DefaultIfEmpty(new State
                                    { StateId = 0, StateName = "" })
                                    select new { e.LastName, item.StateName };
            foreach (var employee in employeeByStateOJ)
            {
                Console.WriteLine(employee.LastName + ", " + employee.StateName);
            }
        }
    }
}
