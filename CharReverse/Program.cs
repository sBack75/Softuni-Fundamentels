using System;
using System.Collections.Generic;
using System.Linq;

namespace CharReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> charList = new List<char>();
            for (int i = 0; i < 3; i++)
            {
                char curChar = char.Parse(Console.ReadLine());
                charList.Add(curChar);
            }
            charList.Reverse();
            Console.WriteLine(string.Join(' ',charList)) ;
        }
    }
}
