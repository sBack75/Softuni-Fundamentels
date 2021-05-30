using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int fromWhere = int.Parse(Console.ReadLine());
            List<int> secondArr = new List<int>();
            while (fromWhere > firstArr.Length)
            {
                fromWhere -= firstArr.Length;
            }



            for (int i = fromWhere; i < firstArr.Length; i++)
            {
                secondArr.Add(firstArr[i]);
            }
            for (int i = 0; i < fromWhere ; i++)
            {
                secondArr.Add(firstArr[i]);
            }

            Console.WriteLine(string.Join(' ', secondArr));
        }
    }
}
