using System;
using System.Linq;
namespace PrintNumberReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMany = int.Parse(Console.ReadLine());
            int[] numbers = new int [howMany];

            for (int i = 0; i < howMany; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            numbers = numbers.Reverse().ToArray();
            Console.WriteLine(string.Join(' ',numbers));

        }
    }
}
