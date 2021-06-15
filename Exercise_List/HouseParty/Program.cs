using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGuest = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();


            for (int i = 0; i < numberOfGuest; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = command[0];
                if (command.Length == 3)
                {
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }
                else if (command.Length == 4)
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else if (true)
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine,guests));
        }
    }
}
