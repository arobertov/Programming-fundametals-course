using System;
using System.Collections.Generic;
using System.Linq;
namespace MaxSequenceEqualElements
{
    class MaxSequence
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var counter = 1;
            var startSeq = 0;
            var start = 0;
            var stopSeq = 1;
            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i-1] == nums[i])
                {
                    counter++;
                    if(counter==2)start = i-1;
                    if (stopSeq < counter)
                    {
                        stopSeq = counter;
                        startSeq = start;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            for (int i = startSeq ; i <(startSeq+stopSeq); i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

