using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseChar
{
    class ReverseChar
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            string temp = c;
            c = a;
            a = temp;
            Console.WriteLine(a+b+c);
        }
    }
}
