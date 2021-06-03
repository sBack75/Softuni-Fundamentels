using System;

namespace MiddleCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();
            MiddleChar(word);
            
        }
        static void MiddleChar (char[] word)
        {
            if (word.Length % 2 == 0)
            {
                Console.WriteLine($"{word[word.Length / 2 - 1]}{word[word.Length / 2]}");
            }
            else if (word.Length % 2 != 0)
            {
                Console.WriteLine(word[word.Length / 2]);
            }
        }
    }
};