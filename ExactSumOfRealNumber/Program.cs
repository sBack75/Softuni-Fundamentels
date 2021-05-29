using System;
using System.Numerics;

namespace ExactSumOfRealNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMany = int.Parse(Console.ReadLine());
            decimal result = 0;

            for (int i = 0; i < howMany; i++)
            {
                decimal curDigit = decimal.Parse(Console.ReadLine());
                result = curDigit + result;
            }
            Console.WriteLine(result);
        }
    }
}
