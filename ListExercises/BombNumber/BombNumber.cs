using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumber
{
    class BombNumber
    {
        static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bombList = Console.ReadLine().Split().Select(int.Parse).ToList();

            var bomb = bombList[0];
            var power = bombList[1];
           
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == bomb)
                {
                  
                    int startIndex = Math.Max(0, i - power);
                    int stop = Math.Min((2 * power) + 1, list.Count - startIndex);
                   
                    list.RemoveRange(startIndex, stop);
                    i = -1;
                }
            }

            long sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            Console.WriteLine(sum);
        }
    }
}
