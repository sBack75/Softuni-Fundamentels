using System;

namespace LowerToUpeer
{
    class Program
    {
        static void Main(string[] args)
        {
            string latter = Console.ReadLine();
            string newLatter = latter.ToUpper();
            if (latter == newLatter)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }

        }
    }
}
