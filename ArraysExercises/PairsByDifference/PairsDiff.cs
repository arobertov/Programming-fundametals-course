using System;
using System.Linq;
namespace PairsByDifference
{
    class PairsDiff
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var diffNumber = int.Parse(Console.ReadLine());
            var count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Math.Abs(nums[i] - nums[j]) == diffNumber)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
    }
}
