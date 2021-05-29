using System;

namespace CharToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = string.Empty;

            for (int i = 0; i < 3; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                word+= symbol.ToString();
            }
            Console.WriteLine(word);
        }
    }
}
