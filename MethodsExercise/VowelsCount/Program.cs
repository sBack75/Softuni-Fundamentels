using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            vowels(word);

        }

        public static void vowels(string word)
        {
            int vowelsCount = 0;
            for (int i = 0; i < word.Length; i++)
            {
                char symbol = word[i];
                if (symbol == 'a' || symbol =='e' || symbol == 'i' || symbol == 'o' || symbol == 'u')
                {
                    vowelsCount++; 
                }
                if (symbol == 'A' || symbol == 'E' || symbol == 'I' || symbol == 'O' || symbol == 'U')
                {
                    vowelsCount++;
                }
            }
            Console.WriteLine(vowelsCount); 
        }
    }
}
