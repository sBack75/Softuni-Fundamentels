using System;

namespace DataTypeAndConversation
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                int sum = 0;

                while (true)
                {
                    int lastNum = i % 10;
                    int firstNum = i / 10;
                    sum = lastNum + firstNum;
                    break;
                }


                bool specialNum = (sum == 5) || (sum == 11) || (sum == 7);

                Console.WriteLine($"{i} -> {specialNum}");
            }
        }
    }
}
