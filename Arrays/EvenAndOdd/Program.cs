using System;
using System.Linq;

namespace EvenAndOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int even = 0;
            int odd = 0;
            int result = 0;
            string evens = string.Empty;
            string odds = string.Empty;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {

                    even += numbers[i];
                }
                else
                {
                    odd += numbers[i];
                }
            }
            result = even - odd;
            Console.WriteLine($"");
        }
    }
}
