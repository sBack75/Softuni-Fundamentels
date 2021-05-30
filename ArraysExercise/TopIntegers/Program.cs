using System;
using System.Collections.Generic;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequance = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            List<int> mostInteger = new List<int>();


            for (int i = 0; i < sequance.Length; i++)
            {
                int curElement = sequance[i];
                bool mostNum = false;

                for (int s = i; s < sequance.Length; s++)
                {
                    if (curElement < sequance[s])
                    {
                        mostNum = true;
                    }
                }
                if (mostNum == false)
                {
                    mostInteger.Add(curElement);
                }
            }
            Console.WriteLine(string.Join(' ',mostInteger));
        }
    }
}
