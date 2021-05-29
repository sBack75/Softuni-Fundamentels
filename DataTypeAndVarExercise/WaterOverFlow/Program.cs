using System;

namespace WaterOverFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int howMany = int.Parse(Console.ReadLine());
            int capacity = 255;
            int curCapacity = 0;
            for (int i = 0; i < howMany; i++)
            {
                int giveCapacity = int.Parse(Console.ReadLine());
                curCapacity += giveCapacity;
                if (curCapacity >= capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    curCapacity -= giveCapacity;
                    continue;
                }
            }
            Console.WriteLine(curCapacity); ;
        }
    }
}
