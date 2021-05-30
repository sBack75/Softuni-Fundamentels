using System;
using System.Linq;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            double[] newNum = new double[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                newNum[i] = Math.Round(numbers[i],MidpointRounding.AwayFromZero);
            }
           

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {newNum[i]}");
            }
        }
    }
}
