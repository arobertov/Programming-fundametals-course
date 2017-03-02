using System;
using System.Collections.Generic;
using System.Linq;
namespace SumAdjacentEqualNumbers
{
    class SumAdjacent
    {
        static void Main()
        {
            List<double> nums = Console.ReadLine().Split().Select(double.Parse).ToList();
            var pos = 0;
            while (pos<nums.Count-1)
            {
                if (nums[pos] == nums[pos + 1])
                {
                    nums.RemoveAt(pos);
                    nums[pos] = 2 * nums[pos];
                    if(pos>0) pos--;
                }
                else pos++;
            }
            Console.WriteLine(string.Join(" ",nums));
        }
    }
}
