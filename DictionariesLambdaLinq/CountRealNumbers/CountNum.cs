namespace CountRealNumbers
{
using System;
using System.Collections.Generic;
using System.Linq;
  public  class CountNum
    {
       public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var numCount = new SortedDictionary<double, int>();
            foreach (var num in input)
            {
                if (!numCount.ContainsKey(num))
                {
                    numCount[num] = 0;
                }
                numCount[num]++;
            }
            foreach (var item in numCount)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
