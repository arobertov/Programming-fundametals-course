using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Char_Arrays
{
    class CompareChar
    {
        static void Main()
        {
            char[] firstArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var len = Math.Min(firstArr.Length, secondArr.Length);
            for (int i = 0; i <len; i++)
            {
                if (firstArr[i] > secondArr[i])
                    {
                        foreach (var second in secondArr) Console.Write(second);
                        Console.WriteLine();
                        foreach (var first in firstArr) Console.Write(first);
                        break;
                    }
                else if(firstArr[i]<secondArr[i])
                    {
                        foreach (var first in firstArr) Console.Write(first);
                        Console.WriteLine();
                        foreach (var second in secondArr) Console.Write(second);
                        break;
                    }
                else if (firstArr.Length < secondArr.Length)
                {
                    foreach (var first in firstArr) Console.Write(first);
                    Console.WriteLine();
                    foreach (var second in secondArr) Console.Write(second);
                    break;
                }
                else if (secondArr.Length<firstArr.Length)
                {
                    foreach (var second in secondArr) Console.Write(second);
                    Console.WriteLine();
                    foreach (var first in firstArr) Console.Write(first);
                    break;
                }
                else
                {
                    foreach (var first in firstArr) Console.Write(first);
                    Console.WriteLine();
                    foreach (var second in secondArr) Console.Write(second);
                    break;
                }
            }

        }
    }
}
