using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Creating_Tasks
{
    class Program
    {
        const int NUMBER_OF_ITERATIONS = 32;
    
        static void Main(string[] args)
        {
             //With .NET 4 Microsoft introduced the Task class, which represents an asynchronous operation.
            //  The tasks are as well a way to abstract away the need for threads from the programmer. It uses
            //  threads from the thread pool but offers a great deal of flexibility and control over how the task is
           //  created.
             //  Let's use a similar example that I used before to test Threads performance improvement 
             Stopwatch sw = Stopwatch.StartNew();
             RunSequential();
             // 33295ms! Wow... Let's comment the RunSequential() line code and uncomment the RunTasks()
             //RunTasks(); 
             //15489ms! It's way better than the RunSequential performance!
             Console.WriteLine("We're done in {0} ms!", sw.ElapsedMilliseconds);
         }
 
         static void RunTasks()
         {
             double result = 0d;
             Task<double>[] tasks = new Task<double>[NUMBER_OF_ITERATIONS];
 
             // We create one task per iteration.
             for (int i = 0; i<NUMBER_OF_ITERATIONS; i++)
             {
                 tasks[i] = Task.Run(() => DoIntensiveCalculations());
             }
 
             // We wait for the tasks to finish
             Task.WaitAll(tasks);
 
             // We collect the results
             foreach (var task in tasks)
             {
                 result += task.Result;
             }
             Console.WriteLine("The result is {0}", result);
         }
 
      static void RunSequential()
         {
             double result = 0d;
             // Here we call same method several times.
             for (int i = 0; i<NUMBER_OF_ITERATIONS; i++)
             {
                 result += DoIntensiveCalculations();
             }
             // Print the result
             Console.WriteLine("The result is {0}", result);
         }
         static double DoIntensiveCalculations()
         {
             double result = 10000d;
             var maxValue = Int32.MaxValue >> 4;
             for (int i = 1; i<maxValue; i++)
             {
                 if (i % 2 == 0)
                 {
                     result /= i;
                 }
                 else {
                     result *= i;
                 }
             }
             return result;
         }
         }
 }