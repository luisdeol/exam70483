using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parallel_Class
{
    class Program
    {
        const int NUMBER_OF_ITERATIONS = 32;
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            //RunSequencial();
            RunParallelForCorrected();
            Console.WriteLine("We are done in {0} ms", sw.ElapsedMilliseconds);
        }
        static void RunParallelForCorrected()
        {
            double result = 0d;
            // Here we call same method several times.
            //for (int i = 0; i < NUMBER_OF_ITERATIONS; i++)
            Parallel.For(0, NUMBER_OF_ITERATIONS,
            // Func<TLocal> localInit,
            () => 0d,
            // Func<int, ParallelLoopState, TLocal, TLocal> body,
            (i, state, interimResult) => interimResult + DoIntensiveCalculations(),
            // Final step after the calculations
            // we add the result to the final result
            // Action<TLocal> localFinally
            (lastInterimResult) => result += lastInterimResult
            );
            // Print the result
            Console.WriteLine("The result is {0}", result);
        }
    
        static double DoIntensiveCalculations()
        {
            // We are simulating intensive calculations
            // by doing nonsense divisions
            double result = 100000000d;
            var maxValue = Int32.MaxValue;
            for (int i = 1; i < maxValue; i++)
            {
                result /= i;
            }
            return result + 10d;
        }
        static void RunSequencial()
        {
            double result = 0d;
            // Call the function to read data from I/O
            result += ReadDataFromIO();
            // Add the result of the second calculation
            result += DoIntensiveCalculations();
            // Print the result
            Console.WriteLine("The result is {0}", result);
        }


        static double ReadDataFromIO()
        {
            // We are simulating an I/O by putting the current thread to sleep.
            Thread.Sleep(5000);
            return 10d;
        }

    }
}
