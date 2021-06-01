using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            double numberTwo = double.Parse(Console.ReadLine());

            switch (symbol)
            {
                case "+":
                    Console.WriteLine(Add(numberOne,numberTwo));
                    break;
                case "-":
                    Console.WriteLine(Subtract(numberOne,numberTwo));
                    break;
                case "/":
                    Console.WriteLine(Divide(numberOne, numberTwo));
                    break;
                case "*":
                    Console.WriteLine(Multiply(numberOne,numberTwo));
                    break;
            }
        }
        static double Add(double numberOne , double numbertwo)
        {
            double result = numberOne + numbertwo;
            return result;
        }
        static double Subtract(double numberOne , double numberTwo)
        {
            double result = numberOne - numberTwo;
            return result;
        }
        static double Divide (double numberOne , double numberTwo)
        {
            double result = numberOne / numberTwo;
            return result;
        }
        static double Multiply(double numberOne , double numberTwo)
        {
            double result = numberTwo * numberTwo;
            return result;
        }
    }
}
