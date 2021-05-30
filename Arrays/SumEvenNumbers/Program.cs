using System;
using System.Collections.Generic;
using System.Linq;

namespace SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            List<int> newList = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    newList.Add(numbers[i]);
                }
            }
            int sum = newList.Sum();
            Console.WriteLine(sum);
        }
    }
}
