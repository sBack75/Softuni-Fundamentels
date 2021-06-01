using System;

namespace CalcReactangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            Console.WriteLine(RectangleArea(numberOne , numberTwo));
        }
        static double RectangleArea (double numOne , double numTwo)
        {
            double result = numOne * numTwo;
            return result;
        }
    }
}
