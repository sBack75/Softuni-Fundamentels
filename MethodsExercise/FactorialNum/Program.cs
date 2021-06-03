using System;

namespace FactorialNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            factorialMetod(numberOne, numberTwo);


        }
        static void factorialMetod (int numberOne , double numberTwo)
        {
            double firstNum = 0;
            double secondNum = 0;
            double sums = 1;
            for (int i = 1; i < numberOne; i++)
            {
                sums = sums * (i + 1);
                firstNum = sums;           
            }
            sums = 1;
            for (int i = 1; i < numberTwo; i++)
            {
                sums = sums * (i + 1);
                secondNum = sums;
            }
            firstNum = firstNum / secondNum;
            Console.WriteLine($"{firstNum:f2}");
        }
    }
}
