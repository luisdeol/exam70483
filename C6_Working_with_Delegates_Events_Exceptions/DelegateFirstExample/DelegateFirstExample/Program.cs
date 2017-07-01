using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFirstExample
{
    class Program
    {
        private static FunctionDelegate delegateFuncao;
        static void Main(string[] args)
        {
            delegateFuncao = Funcao;
            Console.WriteLine(delegateFuncao(2.9));
        }
        private delegate double FunctionDelegate(double x);

        private static double Funcao(double x)
        {
            return (double)(12 * Math.Sin(3 * x) / (1 + Math.Abs(x)));
        }
    }
}
