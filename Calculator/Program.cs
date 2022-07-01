using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Which operation you choose?");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Division");
            Console.WriteLine("4 - Multiplication");
            Console.WriteLine("5 - Leave Application");

            Console.WriteLine("----------------");
            Console.WriteLine("Choose an option:");
            short response = short.Parse(Console.ReadLine());

            switch (response)
            {
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Division(); break;
                case 4: Multiplication(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
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
            Console.WriteLine("");
            Console.WriteLine("Press enter to return");
            Console.ReadKey();
            Menu();
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
            Console.WriteLine("");
            Console.WriteLine("Press enter to return");
            Console.ReadKey();
            Menu();
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
            Console.WriteLine("");
            Console.WriteLine("Press enter to return");
            Console.ReadKey();
            Menu();
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
            Console.WriteLine("");
            Console.WriteLine("Press enter to return");
            Console.ReadKey();
            Menu();
        }
    }
}
