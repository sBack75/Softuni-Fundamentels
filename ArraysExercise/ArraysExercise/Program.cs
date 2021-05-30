using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMany = int.Parse(Console.ReadLine());
            List<int> trainPassagers = new List<int>();

            for (int i = 0; i < howMany; i++)
            {
                int curPassagers = int.Parse(Console.ReadLine());

                trainPassagers.Add(curPassagers);
            }

            int sumAll = trainPassagers.Sum();
            Console.WriteLine(string.Join(' ',trainPassagers));
            Console.WriteLine(sumAll);
        }
    }
}
