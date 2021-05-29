using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();
            double[] num = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            foreach (var key in num)
            {
                if (numbers.ContainsKey(key))
                {
                    numbers[key]++;
                }
                else
                {
                    numbers.Add(key, 1);
                }
            }

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            
        }
    }
}
