using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveEratosthenes
{
    class Eratostenes
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int[] numbers = new int[num + 1];
            int count = 2;

            for (int i = 2; i <= num; i++)
            {
                numbers[i] = count;
                count++;
            }

            for (int i = 2; (i * i) <= num; i++)
            {
                for (int j = (i * i); j <= num; j = j + i)
                {
                    numbers[j] = 0;
                }
            }

            for (int i = 2; i <= num; i++)
            {
                if (numbers[i] != 0) { Console.Write($"{numbers[i]} "); }
            }
        }
    }
}

