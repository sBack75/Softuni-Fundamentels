using System;
using System.Collections.Generic;
using System.Linq;
namespace CaminoFactory
{
    class Program
    {
        static void Main(string[] args)
         {
            int range = int.Parse(Console.ReadLine());
            int starIndex = 0;
            int symbolNum = 0;
            int sequance = 0;
            string[] bestDna = new string[range];
            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (command[0] == "Clone them")
                {
                    break;
                };
                int CurstarIndex = 0;
                int CursymbolNum = 0;
                int Cursequance = 1;
                string[] curDnk = command.ToArray();

                for (int i = 0; i < command.Length; i++)
                {
                    if (command[i] == "1")
                    {
                        int counter = 1;
                      
                        CursymbolNum++;
                        for (int s = i+1; s < command.Length; s++)
                        {
                            if (command[i] == command[s])
                            {
                                counter++;
                                
                            }
                            else
                            {
                                if (counter > Cursequance)
                                {
                                    Cursequance = counter;
                                    CurstarIndex = i;
                                }
                                counter = 1;
                                break;
                            }
                        }
                        if (counter > Cursequance)
                        {
                            Cursequance = counter;
                        }

                    }
                }

                if (Cursequance > sequance)
                {
                    sequance = Cursequance;
                    symbolNum = CursymbolNum;
                    starIndex = CurstarIndex;
                    bestDna = curDnk;
                }
                else if (Cursequance == sequance)
                {
                    if (CurstarIndex < starIndex)
                    {
                        sequance = Cursequance;
                        starIndex = CurstarIndex;
                        symbolNum = CursymbolNum;
                        bestDna = curDnk;

                    }
                    else if (CurstarIndex == starIndex)
                    {
                        if (symbolNum < CursymbolNum)
                        {
                            sequance = Cursequance;
                            starIndex = CurstarIndex;
                            symbolNum = CursymbolNum;
                            bestDna = curDnk;

                        }
                    }

                }
            }
            Console.WriteLine($"Best DNA sample {starIndex+1} with sum: {symbolNum}.");
            Console.WriteLine(string.Join(' ',bestDna));

        }
    }
}
