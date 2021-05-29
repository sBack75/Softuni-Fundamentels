using System;

namespace DollarConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pound = decimal.Parse(Console.ReadLine());
            decimal result = pound * 1.31M;
            Console.WriteLine($"{result:f3}");
        }
    }
}
