using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string curString = Console.ReadLine();
            int howMany = int.Parse(Console.ReadLine());
            Console.WriteLine(Repeater(curString , howMany));

        }
        static string Repeater (string curStr , int number)
        {
            string result = string.Empty;
            for (int i = 0; i < number; i++)
            {
                result += curStr;
                
            }
            return result;
        }
    }
}
