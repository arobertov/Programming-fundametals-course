using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers
{
    class SortNumber
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            nums.Sort();
            Console.WriteLine(string.Join(" => ",nums));
        }
    }
}
