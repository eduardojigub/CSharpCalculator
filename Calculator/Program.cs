using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sum();
            // Subtraction();
            // Division();
            Multiplication();
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
            Console.ReadKey();
        }
        static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("Type the first value:");
            float firstValue = float.Parse(Console.ReadLine());
            Console.WriteLine("Type the second value:");
            float secondValue = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float SubtractionResult = firstValue - secondValue;
            Console.WriteLine($"The subtraction result is: {SubtractionResult}");
            Console.ReadKey();
        }
        static void Division()
        {
            Console.Clear();
            Console.WriteLine("Type the first value:");
            float firstValue = float.Parse(Console.ReadLine());
            Console.WriteLine("Type the second value:");
            float secondValue = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float DivisionResult = firstValue / secondValue;
            Console.WriteLine($"The sum result is: {DivisionResult}");
            Console.ReadKey();
        }
        static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("Type the first value:");
            float firstValue = float.Parse(Console.ReadLine());
            Console.WriteLine("Type the second value:");
            float secondValue = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float MultiplicationResult = firstValue * secondValue;
            Console.WriteLine($"The sum result is: {MultiplicationResult}");
            Console.ReadKey();
        }
    }
}
