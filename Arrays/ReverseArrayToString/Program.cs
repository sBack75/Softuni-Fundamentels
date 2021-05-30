using System;
using System.Linq;

namespace ReverseArrayToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();
            Console.WriteLine(string.Join(' ',input));
        }
    }
}
