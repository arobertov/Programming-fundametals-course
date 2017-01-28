using System;
using System.Linq;
namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string[] reverce = input.Reverse().ToArray();
            foreach (var item in reverce)
            {
                Console.WriteLine(String.Join(" ", item));
            }
        }
    }
}
