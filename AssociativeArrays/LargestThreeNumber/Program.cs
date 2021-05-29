using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestThreeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lineNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            int[] sordNum = lineNumbers.OrderBy(n => n)
                .Reverse()
                .ToArray();
           
            int index = sordNum.Length>=3?3:sordNum.Length;

            for (int i = 0; i < index; i++)
            {
                Console.Write(sordNum[i] + " ");
            }
           
        }
    }
}
