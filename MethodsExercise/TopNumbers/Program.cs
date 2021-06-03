using System;

namespace TopNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberEnd = int.Parse(Console.ReadLine());
            TopNum(numberEnd);

            
        }
        static void TopNum (int endNum)
        {
            for (int i = 10; i <= endNum; i++)
            {
                int sum = 0;
                string leng = i + "";
                int digit = i;
                for (int s = 1; s <= leng.Length; s++)
                {

                    sum += digit % 10;
                    digit /= 10;
                }
                if (sum % 8 == 0)
                {
                    if (i % 2 !=0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

    }
}
