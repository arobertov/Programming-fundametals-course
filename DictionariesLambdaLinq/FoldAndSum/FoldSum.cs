using System;
using System.Collections.Generic;
using System.Linq;
namespace FoldAndSum
{
    class FoldSum
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var k = nums.Length / 4;
            var leftPart = nums.Take(k).Reverse().ToArray();
            var rightPart = nums.Reverse().Take(k).ToArray();
            var row1 = leftPart.Concat(rightPart).ToArray(); ;
            var midPart = nums.Skip(k).Take(2 * k).ToArray();
            var result = row1.Select((x,index)=>x+midPart[index]);
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
