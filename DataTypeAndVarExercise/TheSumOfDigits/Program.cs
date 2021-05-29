using System;

namespace TheSumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int theDigits = int.Parse(Console.ReadLine());
            string longs = theDigits + "";
            double sum = 0;
            for (int i = 0; i < longs.Length; i++)
            {
                double curDigit = theDigits % 10;
                theDigits = theDigits / 10;
                sum += curDigit;
            }
            Console.WriteLine(sum);
        }
    }
}
