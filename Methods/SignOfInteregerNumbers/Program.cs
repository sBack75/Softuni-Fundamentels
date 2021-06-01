using System;

namespace SignOfInteregerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int giveNumber = int.Parse(Console.ReadLine());
            PositiveOrNegative(giveNumber);

        }
        static void PositiveOrNegative (int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
