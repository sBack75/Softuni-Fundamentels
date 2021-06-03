using System;
using System.Linq;
namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
           

            while (true)
            {
                string commands = Console.ReadLine();
                if (commands == "END")
                {
                    break;
                }
                int specNum = int.Parse(commands);
                Palindrome(specNum);
                
            }
            static void Palindrome(int specNum)
            {
                string polindrome = specNum+"";
                int[] polindromeHave = new int[polindrome.Length];
                int[] reversePolindrom = new int[polindrome.Length];
                int different = 0;
                for (int i = 0; i < polindrome.Length; i++)
                {
                    polindromeHave[i] = polindrome[i];
                }
                for (int s = polindromeHave.Length; s > 0; s--)
                {
                    reversePolindrom[polindromeHave.Length - s] = polindromeHave[s-1];
                }
                for (int i = 0; i < polindromeHave.Length; i++)
                {
                    if (polindromeHave[i] == reversePolindrom[i])
                    {
                       
                    }
                    else
                    {
                        different++;
                    }
                }
                if (different == 0)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
               
            }
        }
    }
}
