using System;
using System.Collections.Generic;
using System.Linq;
namespace ShortWordsSorted
{
    class ShortWords
    {
        static void Main()
        {
            char[] separator = new char [] { '.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' ' };
            var words = Console.ReadLine().ToLower().Split(separator).ToList();
            var result = words.Where(w => w != "")
                .Where(w => w.Length<5)
                .OrderBy(w => w).Distinct();
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
