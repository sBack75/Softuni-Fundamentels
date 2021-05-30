using System;
using System.Linq;

namespace ConsendArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digitArray = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            while (true)
            {
                if (digitArray.Length <=0)
                {
                    break;
                }
                for (int i = 0; i < digitArray.Length-1; i++)
                {
                    digitArray[i] = digitArray[i] + digitArray[i + 1];
                }
            }
                        
        }
    }
}
