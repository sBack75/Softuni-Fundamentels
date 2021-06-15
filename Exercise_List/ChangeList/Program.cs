using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberOfList = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (command[0] == "end")
                {
                    break;
                }
                if (command[0] == "Delete")
                {
                    int deleteNum = int.Parse(command[1]);

                    numberOfList.RemoveAll(x=>x == deleteNum);                       
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[2]);
                    int number = int.Parse(command[1]);

                    numberOfList.Insert(index, number);
                }
            }

            Console.WriteLine(string.Join(' ',numberOfList));
        }
    }
}
