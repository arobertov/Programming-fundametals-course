using System;
using System.Collections.Generic;
using System.Linq;
namespace SumMinMaxAverage
{
    class SumMin
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int [] numbers = new int [n];
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                
                numbers[i] = num;
            }
            Console.WriteLine("Sum = {0}",numbers.Sum());
            Console.WriteLine("Min = {0}",numbers.Min());
            Console.WriteLine("Max = {0}",numbers.Max());
            Console.WriteLine("Average = {0}",numbers.Average());
        }
    }
}
