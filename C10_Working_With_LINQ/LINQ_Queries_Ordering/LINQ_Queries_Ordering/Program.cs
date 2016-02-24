using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Queries_Ordering
{
    class Program
    {
        class State
        {
            public int StateId { get; set; }
            public string StateName { get; set; }
            public int Population { get; set; }
        }

        static void Main(string[] args)
        {
            List<State> states = new List<State>()
            {
                new State() { StateId = 1, StateName = "San Pablo", Population = 10000 },
                new State() { StateId = 2, StateName = "Madrid", Population = 50000 },
                new State() { StateId = 3, StateName = "Amazonas", Population = 50000 }
            };
            /*As you can see below, you can chain the OrderBy method! In that case, I ordered ascending by Population
            then Descending by StateName! */

            var orderedStates = states.OrderBy(h => h.Population).ThenByDescending(h => h.StateName);

            foreach (var state in orderedStates)
            {
                Console.WriteLine(String.Format("Name: {0}, Population: {1}", state.Population, state.StateName));
            }
        }
    }
}
