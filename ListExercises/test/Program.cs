using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main()
        {
            var lists = new List <int>{ 1, 2, 3, 4, 5 ,6};
            var temp = new List<int> { 10, 10, 10 };

            lists = temp;
        }
    }
}
