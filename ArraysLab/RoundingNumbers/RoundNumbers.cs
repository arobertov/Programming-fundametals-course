using System;
using System.Linq;
namespace RoundingNumbers
{
    class RoundNumbers
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            foreach (var item in nums)
            {
                var round = RoundNumbers(item);
                Console.WriteLine($"{item} => {round}");
            }
        }

        private static double RoundNumbers(double item)
        {
            var round = Math.Round(item, MidpointRounding.AwayFromZero);
            return round;
        }
    }
    }
}
