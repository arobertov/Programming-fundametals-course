using System;
using System.Linq;
namespace IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main()
        {
            var input = Console.ReadLine().ToArray();//____ input string ___________//

            char[] charArr = new char[('z' - 'a') + 1];

            for (int i = 0; i <= 'z' - 'a'; i++)
            {
                charArr[i] = Convert.ToChar(i + 'a'); //_________Create  a-z  array__// 
            }
            //=======================================================================//
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < charArr.Length; j++)
                {
                    if (input[i] == charArr[j])
                    {
                        Console.WriteLine($"{input[i]} -> {j}");
                    }
                }
            }
        }
    }
}
