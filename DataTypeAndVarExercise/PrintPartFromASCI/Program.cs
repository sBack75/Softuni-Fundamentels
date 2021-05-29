using System;
using System.Collections.Generic;

namespace PrintPartFromASCI
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            List<char> charList = new List<char>();

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                char curChar = (char)i;
                charList.Add(curChar);
            }
            Console.WriteLine(string.Join(' ',charList));
        }
    }
}
