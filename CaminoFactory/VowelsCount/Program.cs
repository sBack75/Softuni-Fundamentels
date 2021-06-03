using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            word = word.ToLower().ToString();
            int result =VowelsCounter(word);
            Console.WriteLine(result);

        }
        static int VowelsCounter (string word)
        {
            char[] latterCount = word.ToCharArray();
            int counter = 0;

            for (int i = 0; i < latterCount.Length; i++)
            {
                if (latterCount[i] == 'a' || latterCount[i] == 'e' || latterCount[i] == 'i' || latterCount[i] == 'o' || latterCount[i] == 'u' )
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
