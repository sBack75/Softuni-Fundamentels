using System;

namespace MiddleChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] symbols = new char[word.Length];
            for (int i = 0; i < symbols.Length; i++)
            {
                symbols[i] = word[i];
            }
            operation(symbols);
            
        }
        static void operation(char[] symbols)
        {
           
            int sum = symbols.Length / 2;

            if (symbols.Length % 2 == 0)
            {
                if (symbols.Length % 2 == 0)
                {
                    Console.Write(symbols[sum - 1]);
                    Console.Write(symbols[sum]);
                }
            }
            else
            {
                Console.Write(symbols[sum]);
            }
        }
    }
}
