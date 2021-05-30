using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int howManyPerDay = int.Parse(Console.ReadLine());
            int total = 0;
            int consumation = 26;
            int days = 0;
            if (howManyPerDay < 100)
            {

            }
            else
            {
                while (true)
                {
                    if (howManyPerDay < 100)
                    {
                        total -= consumation;
                        break;
                    }
                    total += howManyPerDay;
                    if (total < consumation)
                    {
                        break;
                    }
                    else
                    {
                        total -= consumation;
                    }
                    days++;
                    howManyPerDay -= 10;

                }
            }
            Console.WriteLine(days);
            Console.WriteLine(total);
        }
    }
}
