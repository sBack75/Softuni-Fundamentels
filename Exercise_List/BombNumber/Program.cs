using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumber = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int[] specNumAndPower = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int specNum = specNumAndPower[0];
            int range = specNumAndPower[0];
            int sum = 0;
            for (int i = 0; i < listOfNumber.Count-1; i++)
            {
                if (listOfNumber[i] == specNum)
                {
                    for (int s = i+1; s < range; s++)
                    {
                        if (listOfNumber[s] != specNum)
                        {
                            if (s < listOfNumber.Count)
                            {
                                listOfNumber.RemoveAt(s);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    for (int th = i -1 ; th >= 0; th++)
                    {
                        if (th )
                        {

                        }
                    }
                }
            }


        }
    }
}
