using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int needNumber = int.Parse(Console.ReadLine());
            List<string> numbers = new List<string>();

            for (int i = 0; i < myArray.Length; i++)
            {
                int curNum = myArray[i];

                for (int s = i+1; s < myArray.Length; s++)
                {
                    if (curNum + myArray[s] == needNumber)
                    {
                        numbers.Add($"{curNum} {myArray[s]}");

                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine,numbers));
        }
    }
}
