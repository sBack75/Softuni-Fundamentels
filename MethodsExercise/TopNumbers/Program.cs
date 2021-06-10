using System;
using System.Linq;
using System.Collections.Generic;

namespace TopNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine( );
            List<int> result = TopNumberFirstPart(number);
            Console.WriteLine(string.Join(Environment.NewLine ,result));
        }
        static List<int> TopNumberFirstPart(string number)
        {
            List<int> result = new List<int>();
                    
            for (int i = 10; i < int.Parse(number); i++)
            {
                char[] curSumbol = i.ToString().ToCharArray();
                int[] allNum = new int[curSumbol.Length];
                for (int s = 0; s < curSumbol.Length; s++)
                {
                    allNum[s] = int.Parse(curSumbol[s].ToString());
                }
                int sum = allNum.Sum();

                if (sum % 8 == 0)
                {
                    if (allNum[allNum.Length-1] % 2 != 0)
                    {
                        result.Add(i);
                    }
                }
            }

            return result;
            
            
            
        }
    }
}
