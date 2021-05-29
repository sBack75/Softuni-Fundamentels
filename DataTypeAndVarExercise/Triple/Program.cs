using System;

namespace Triple
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number += 97-3;
            char curChar = (char)number;

            for (char i = curChar; i < curChar+3; i++)
            {
                for (char s = curChar; s < curChar+3; s++)
                {
                    for (char th = curChar; th < curChar+3; th++)
                    {
                        Console.WriteLine($"{i}{s}{th}");
                    }
                }
            }
        }
    }
}
