using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleNumber = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            int courses = 0;
            while (peopleNumber > 0)
            {
                peopleNumber = peopleNumber - elevatorCapacity;
                courses++;
            }
            Console.WriteLine(courses);
        }
    }
}
