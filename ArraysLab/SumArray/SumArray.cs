using System;
using System.Linq;
using System.Text;
namespace SumArray
{
    class SumArray
    {
        static void Main()
        {
            var firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var len1 = firstArray.Length;
            var len2 = secondArray.Length;

            int[] sumArray = new int[Math.Max(len1, len2)];

            for (int i = 0; i < sumArray.Length; i++)
            {

                sumArray[i] = firstArray[i % len1] + secondArray[i % len2];
            }

            StringBuilder result = new StringBuilder();

            foreach (var print in sumArray)
            {
                result.Append(print).Append(" ");
            }
            Console.WriteLine(result);
        }
    }
}
