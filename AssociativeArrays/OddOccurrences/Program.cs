using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> oddLenght = new Dictionary<string, int>();
            string[] elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var item in elements)
            {
                string curElement = item.ToLower();

                if (oddLenght.ContainsKey(curElement))
                {
                    oddLenght[curElement]++;
                }
                else
                {
                    oddLenght.Add(curElement, 1);
                }

            }
            foreach (var item in oddLenght)
            {
                if (item.Value % 2 == 1)
                {
                    Console.WriteLine(item.Key);
                }
            }


        }
    }
}
