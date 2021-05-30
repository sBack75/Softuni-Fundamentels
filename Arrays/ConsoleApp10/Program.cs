using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays =
            {
                "Monday","Tuesday" ,"Wednesday" ,"Thursay" , "Friday" ,"Saturday" , "Sunday" 
            };

            int giveNumber = int.Parse(Console.ReadLine()) - 1;

            if (giveNumber > 6 || giveNumber < 0)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine($"{weekDays[giveNumber]}");
            }
        }
    }
}
