using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Condense
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var count = 1;
            var start = 0;
            var stop = 1;
            var startPos = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    count++;
                    if (count == 2) start = (i - 1);
                    if (count > stop)
                    {
                        stop = count;
                        startPos = start;
                    }
                }
                else count = 1;
            }
            for (int i = startPos; i < startPos + stop; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
