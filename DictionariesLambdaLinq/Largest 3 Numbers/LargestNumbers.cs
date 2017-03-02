using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_3_Numbers
{
    class LargestNumbers
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
           var  sortedNum = nums.OrderByDescending(a => a);
            var largeNum = sortedNum.Take(3);
            Console.WriteLine(string.Join(" ",largeNum));

        }
    }
}
