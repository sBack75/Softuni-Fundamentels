using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMany = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < howMany; i++)
            {
                char curSymbol = char.Parse(Console.ReadLine());
                sum += curSymbol;

            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
