using System;
using System.Linq;
using System.Collections.Generic;

namespace PolindromIntegers
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                char []word = Console.ReadLine()
                    .ToCharArray();
                char[] wordReverse = word.Reverse().ToArray();

                if (word[0] == 'E' && word[1] == 'N')
                {
                    break;
                }
                Polindroms(word, wordReverse);
            }

        }
        static void Polindroms(char[] word, char[] wordReverse)
        {
            bool polin = true;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == wordReverse[i])
                {

                }
                else
                {
                    polin =false;
                }
            }
            if (polin == true)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
