using System;
using System.Collections.Generic;
using System.Linq;

namespace Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMany = int.Parse(Console.ReadLine());
            List<int> firstArr = new List<int>();
            List<int> secondArr = new List<int>();

            for (int i = 0; i < howMany; i++)
            {
                int[] curArr = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 == 0)
                {
                    firstArr.Add(curArr[0]);
                    secondArr.Add(curArr[1]);

                }
                else
                {
                    firstArr.Add(curArr[1]);
                    secondArr.Add(curArr[0]);
                }
            }
            Console.WriteLine(string.Join(' ',firstArr));
            Console.WriteLine(string.Join(' ',secondArr));
        }
    }
}
