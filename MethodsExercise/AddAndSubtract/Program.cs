using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            Sums(numberOne, numberTwo, numberThree);

        }
        static void Sums(int numberOne, int numberTwo, int numberThree)
        {
            int sums = numberOne + numberTwo;
            sums = sums - numberThree;
           // sums = Math.Abs(sums);
            Console.WriteLine(sums);
        }
    }
}
