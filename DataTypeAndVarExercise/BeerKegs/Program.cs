using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMany = int.Parse(Console.ReadLine());
            double mostBig = double.MinValue;
            string theWinner = string.Empty;

            for (int i = 0; i < howMany; i++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                double kegHeight = double.Parse(Console.ReadLine());

                double result = Math.PI * Math.Pow(kegRadius,2) * kegHeight;

                if (result > mostBig)
                {
                    mostBig = result;
                    theWinner = kegModel;
                }
            }
            Console.WriteLine(theWinner);
        }
    }
}
