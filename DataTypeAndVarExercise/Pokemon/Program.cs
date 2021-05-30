using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePowerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());
            int pokeCount = 0;

            while (true)
            {
                if (pokePowerN == distanceM)
                {

                }
                if (pokePowerN - distanceM >= 0)
                {
                    pokeCount++;
                    pokePowerN -= distanceM;
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine(pokePowerN);
            Console.WriteLine(pokeCount);

            //Solving only part one from exercise
        }
    }
}
