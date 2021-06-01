using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualElements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sequance = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            List<int> mostSequance = new List<int>();

            for (int i = 0; i < sequance.Length; i++)
            {
                int curNum = sequance[i];
                List<int> curList = new List<int>();

                for (int s = i+1; s < sequance.Length; s++)
                {
                    if (curNum == sequance[s])
                    {
                        curList.Add(curNum);
                    }
                    else
                    {
                        break;
                    }
                }
                curList.Add(curNum);
                if (curList.Count > mostSequance.Count)
                {
                    mostSequance = curList.ToList();
                }
            }
            Console.WriteLine(string.Join(' ',mostSequance));
        }
    }
}
