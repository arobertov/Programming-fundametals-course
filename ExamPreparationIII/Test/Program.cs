using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {

        static void Main(string[] args)
        {
            char[] car = new char[] { 'a','b','v','g','z'};
            var text = "dert ";
            Console.WriteLine(string.Join(" ",text.ElementAt(0))); 
            Console.WriteLine(string.Join(" ",car));
        }
    }
}
