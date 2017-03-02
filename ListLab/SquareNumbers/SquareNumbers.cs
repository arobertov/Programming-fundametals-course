using System;
using System.Collections.Generic;
using System.Linq;
namespace SquareNumbers
{
    class SquareNumbers
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split().Select(double.Parse).ToList();
            var result = new List<double>();
            foreach (var item in nums)
            {
                var sqare = Math.Sqrt(item);
                if (sqare == (int)(sqare))
                {
                    result.Add(item);
                }
            }
            result.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
