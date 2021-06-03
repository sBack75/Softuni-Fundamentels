using System;

namespace FactorialDevision
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            numberOne = FactorialDevision(numberOne);
            numberTwo = FactorialDevision(numberTwo);
            int result = numberOne / numberTwo;
            Console.WriteLine($"{result:f2}");
        }
        static int FactorialDevision(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
