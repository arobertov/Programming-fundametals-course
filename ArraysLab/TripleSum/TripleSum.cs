using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum
{
    class TripleSum
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool triple = false;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int a = nums[i];
                    int b = nums[j];
                    int sum = a + b;
                    if (nums.Contains(sum))
                    {
                        Console.WriteLine($"{a} + {b} == {sum}");
                        triple = true;
                    }
                }
            }
            if (!triple) Console.WriteLine("No");
        }
    }
}
