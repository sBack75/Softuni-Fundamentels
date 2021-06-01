using System;
using System.Collections.Generic;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            List<string> elements = new List<string>();
            int index = 0;
            while (true)
            {

                string[] command = Console.ReadLine()
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                int curIndex = 0;
                if (command[0] == "Clone them!")
                {
                    break;
                }

                
                string[] elementsInWhile = command.Where(x=>x == "1").ToArray();
                for (int i = 0; i < command.Length; i++)
                {
                    if (command[i] == "1")
                    {
                        curIndex = i;
                        break;
                    }
                }

                if (elements.Count == elementsInWhile.Length)
                {
                    if (curIndex < index)
                    {
                        elements = elementsInWhile.ToList();
                    }
                }
                elements = elementsInWhile.ToList();
               // НЕ е довършена

            }
        }
    }
}
