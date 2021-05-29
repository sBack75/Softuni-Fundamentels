using System;
using System.Numerics;
namespace CenturiosToMinute
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal howMany = decimal.Parse(Console.ReadLine());
            decimal years = howMany * 100;
            decimal days = Math.Floor(years * 365.2422m);
            decimal hours = days * 24;
            decimal minutes = hours * 60;

            Console.WriteLine($"{howMany} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes ");

        }
    }
}
