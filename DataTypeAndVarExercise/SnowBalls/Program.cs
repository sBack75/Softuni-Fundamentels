using System;

namespace SnowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMany = int.Parse(Console.ReadLine());
            double result = 0;
            double theBestShow = 0;
            double theBestTime = 0;
            double theBestValue = double.MinValue;
            double theBestQuality = 0;

            for (int i = 0; i < howMany; i++)
            {
                double snowShow = double.Parse(Console.ReadLine());
                double snowTime = double.Parse(Console.ReadLine());
                double snowQuality = double.Parse(Console.ReadLine());

                double calc = snowShow / snowTime;
                calc = Math.Pow(calc, snowQuality);

                if (calc > theBestValue)
                {
                    theBestValue = calc;
                    theBestShow = snowShow;
                    theBestTime = snowTime;
                    theBestQuality = snowQuality;
                }
            }
            Console.WriteLine($"{theBestShow} : {theBestTime} = {theBestValue} ({theBestQuality})");
            // We don't have full success with this exercise we take 90/100 
        }
    }
}
