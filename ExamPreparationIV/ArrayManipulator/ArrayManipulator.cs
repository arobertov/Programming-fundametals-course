using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main()
        { 
            var arr = new int[] { 1, 3, 5, 7, 9 };
            var temp1 = arr.Skip(2);
            var temp2 = arr.Take(2);
            Console.WriteLine(string.Join(" ",temp1.Concat(temp2)));
        }
    }
}
