using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Using_Threadpool
{
    class Program
    {
        static void Main(string[] args)
        {
            /*In .NET there is a class called System.Threading.ThreadPool used when you want to work with threads from 
            the thread pool, which would improve the overall performance since the threads would be pre-created.
            This code shows a program that must do two things: read data from I/O and do some intensive calculations.
            The implementation of the two methods is not important in this context; they simulate the intended
            behavior. In a real application the assumption is that the ReadFromIO method does real I/O operations,
            such as reading files or requiring data from the network, whereas DoIntensiveCalculations does calculations
            needed for the application.*/

            double result = 0d;

            ThreadPool.QueueUserWorkItem((x) => result += ReadDataFromIO());
            double result2 = DoIntensiveCalculations();
            result += result2;

            Console.WriteLine("The reuslt is {0}", result);
        }
        static double ReadDataFromIO()
        {
            // We are simulating an I/O by putting the current thread to sleep.
            Thread.Sleep(5000);
            return 10d;
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
    }
}
