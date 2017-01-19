using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects
{
    class StrToObject
    {
        static void Main(string[] args)
        {
            string firstWord = "Hello";
            string secondWord = "World";
            string concatenateWord = firstWord + " " + secondWord;
            object result = concatenateWord;
            Console.WriteLine(result);
        }
    }
}
