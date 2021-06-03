using System;

namespace NxX_Matric
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Matrix(num);

        }
        static void Matrix(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write(num+ " ");
                for (int s = 1; s < num; s++)
                {
                    Console.Write(num+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
