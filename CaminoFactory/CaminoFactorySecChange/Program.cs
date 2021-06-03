using System;
using System.Collections.Generic;
using System.Linq;

namespace CaminoFactorySecChange
{
    class Program
    {
        static void Main(string[] args)
        {
            int howLong = int.Parse(Console.ReadLine());
            int mostSequences = 0;
            int mostStrIndex = 0;
            int mostGreatSum = 0;
            int sample = 0;
            int bestSample = 0;
            string[] bestDna = new string[howLong];
            while (true)
            {
                int curSequences = 1;
                int curStrIndex = 0;
                int curGreatSum = 0;
                string[] curBestDna = new string[howLong];
                string[] commands = Console.ReadLine()
                .Split('!', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                if (commands[0] == "Clone them")
                {
                    break;
                }
                else
                {
                    curBestDna = commands.ToArray();
                    sample++;
                }
                foreach (var item in commands)
                {
                    if (item == "1")
                    {
                        curGreatSum++;
                    }
                }

                for (int i = 0; i < commands.Length; i++)
                {
                    
                    string curSymbol = commands[i];
                    int insertSequance = 0;
                    int index = i;
                    if (curSymbol == "1")
                    {
                        //curGreatSum++;
                        for (int s = index+1; s < commands.Length; s++)
                        {
                            if (commands[s] == curSymbol)
                            {
                                curStrIndex = i;
                                insertSequance++;
                                i++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (insertSequance > curSequences)
                        {
                            curSequences = insertSequance+1;
                            
                        }
                    }
                }
                
                              
                              
                              

                if (curSequences > mostSequences)
                {
                    mostSequences = curSequences;
                    mostStrIndex = curStrIndex;
                    mostGreatSum = curGreatSum;
                    bestDna = curBestDna.ToArray();
                    bestSample = sample;
                }
                else if (curSequences == mostSequences)
                {
                    if (curStrIndex < mostStrIndex)
                    {
                        mostSequences = curStrIndex;
                        mostStrIndex = curStrIndex;
                        mostGreatSum = curGreatSum;
                        bestDna = curBestDna.ToArray();
                        bestSample = sample;


                    }
                    else if (curStrIndex == mostStrIndex)
                    {
                        if (curGreatSum > mostGreatSum)
                        {
                            mostSequences = curStrIndex;
                            mostStrIndex = curStrIndex;
                            mostGreatSum = curGreatSum;
                            bestDna = curBestDna.ToArray();
                            bestSample = sample;

                        }
                    }
                }

            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {mostGreatSum}.");
            Console.WriteLine(string.Join(' ',bestDna));
        }
    }
}
