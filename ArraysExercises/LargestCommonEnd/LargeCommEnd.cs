using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class LargeCommEnd
    {
        static void Main()
        {
            var firstArray = Console.ReadLine().Split(' ');
            var secondArray = Console.ReadLine().Split(' ');
            int leftCounter = 0;
            int rightCounter = 0;
            var shortLenght = Math.Min(firstArray.Length,secondArray.Length);
            for (int i = 0; i < shortLenght; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    leftCounter++;
                }
                else break;
            }
            for (int i = 0; i < shortLenght; i++)
            {
                if (firstArray[firstArray.Length - 1 - i] == secondArray[secondArray.Length - 1 - i])
                {
                    rightCounter++;
                }
                else break; 
            }

            Console.WriteLine(Math.Max(leftCounter,rightCounter));
        }
    }
}
