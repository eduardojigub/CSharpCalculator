using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum();
        }
        static void Sum()
        {
            Console.Clear();
            Console.WriteLine("Type the first value:");
            float firstValue = float.Parse(Console.ReadLine());
            Console.WriteLine("Type the second value:");
            float secondValue = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float SumResult = firstValue + secondValue;
            Console.WriteLine($"The sum result is: {SumResult}");
        }
    }
}
