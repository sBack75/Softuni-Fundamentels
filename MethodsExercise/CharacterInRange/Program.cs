using System;

namespace CharacterInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            CharRange(secondSymbol, firstSymbol);


        }
        static void CharRange(char firstSym , char secondSym)
        {
            if (firstSym > secondSym)
            {
                char save = secondSym;
                secondSym = firstSym;
                firstSym = save;
            }
            else
            {
                
            }
            for (int i = firstSym+1; i < secondSym; i++)
            {
                Console.Write((char)i+" ");
            }
        }
    }
}
