using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayFirst = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] arraySecond = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            bool identical = true;
            for (int i = 0; i < arrayFirst.Length; i++)
            {
                if (arrayFirst[i] != arraySecond[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    identical = false;
                    break;
                }
                else
                {
                    identical = true;
                }
            }
            if (identical == true)
            {
                Console.WriteLine($"Arrays are identical. Sum: {arrayFirst[arrayFirst.Length-1] + arraySecond[arraySecond.Length-1]}");
            }
        }
    }
}
