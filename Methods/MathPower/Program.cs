using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo= double.Parse(Console.ReadLine());
            double result = MathPower(numberOne, numberTwo);
            Console.WriteLine(result);

        }
        static double MathPower (double numOne , double numTwo)
        {
            double result = Math.Pow(numOne, numTwo);
            return result;
        }
    }
}
