using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldSum
{
    class FoldSum
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var len = (num.Length) / 4;
            var reverse = new int[len*2];
            var midle = new int[len*2];
            var sumArr = new int[len * 2];
            for (int i = 0; i < len; i++)
            {
                reverse[i] =num[len-1-i];
                reverse[len + i] = num[(len * 4) -1- i];
            }
            for (int i = 0; i < 2*len; i++)
            {
                midle[i] = num[len+i];
            }
            for (int i = 0; i <len*2; i++)
            {
                sumArr[i] = reverse[i] + midle[i];
            }

            Console.WriteLine(string.Join(" ",sumArr));
        }
    }
}
