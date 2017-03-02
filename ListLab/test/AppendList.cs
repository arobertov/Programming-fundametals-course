using System;
using System.Collections.Generic;
using System.Linq;
namespace AppendList
{
    class Program
    {
        static void Main()
        {
            var lists = Console.ReadLine().Split('|');
            var result = new List<string>();

            for (int i = 0; i < lists.Length; i++)
            {
                var list = lists[lists.Length-i-1].Split(' ');
                foreach (var item in list)
                {
                   if(item!="") result.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ",result)); 
        }
    }
}
