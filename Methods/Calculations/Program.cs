using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            switch (command)
            {
                case "add":
                    Add(firstNumber, secondNumber);
                    break;
                case "subtract":
                    Subtract(firstNumber, secondNumber);
                    break;
                case "multiply":
                    Multiply(firstNumber, secondNumber);
                    break;
                case "divide":
                    Divide(firstNumber, secondNumber);
                    break;
            }
        }

        static void Add (double numOne , double numTwo)
        {
            double result = numOne + numTwo;
            Console.WriteLine(result);
        }
        static void Subtract(double numOne, double numTwo)
        {
            double result = numOne - numTwo;
            Console.WriteLine(result);
        }
        static void Divide(double numOne, double numTwo)
        {
            double result = numOne / numTwo;
            Console.WriteLine(result);
        }
        static void Multiply(double numOne, double numTwo)
        {
            double result = numOne * numTwo;
            Console.WriteLine(result);
        }
    }
}
