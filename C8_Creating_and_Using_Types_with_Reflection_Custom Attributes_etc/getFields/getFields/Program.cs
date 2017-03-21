using System;
using System.Globalization;
using System.Reflection;

namespace getFields
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new CostCalculator();
            var finalprice = calculator.CalculateFinalPrice(30);
            Console.WriteLine($"Final Price: {finalprice.ToString(CultureInfo.InvariantCulture)}");
            var calc = typeof(CostCalculator);
            var fields = calc.GetFields(BindingFlags.FlattenHierarchy | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);

            foreach (var field in fields)
            {
                Console.WriteLine($"Field: {field.Name} - Value: {field.GetValue(calculator)}");
            }

            calc.GetField("_conversionFactor", BindingFlags.NonPublic|BindingFlags.Instance).SetValue(calculator, 0.01);

            var newPrice = calculator.CalculateFinalPrice(30);
            Console.WriteLine($"New Final Price, after changing _conversionFactor using Reflection: {newPrice.ToString(CultureInfo.InvariantCulture)}");
        }

        public class CostCalculator
        {
            private readonly double _conversionFactor = 0.123;
            private readonly int _fixedProfit = 10;

            public double CalculateFinalPrice(int costToProduce)
            {
                return _conversionFactor * costToProduce + _fixedProfit;
            }
        }

    }
}
