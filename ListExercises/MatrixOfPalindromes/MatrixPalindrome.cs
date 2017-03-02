using System;
using System.Collections.Generic;
using System.Linq;
namespace MatrixOfPalindromes
{
    class MatrixPalindrome
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 'a'; i < input[0]+'a'; i++)
            {
                for (int j = i; j < input[1]+i; j++)
                {
                    Console.Write("{0}{1}{0} ",(char)i,(char)j);
                }
                Console.WriteLine();
            }
        }
    }
}