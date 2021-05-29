using System;

namespace ConverMeterToKilo
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());

            double result = meters * 0.100;
            
            Console.WriteLine($"{result:f2}");
        }
    }
}
