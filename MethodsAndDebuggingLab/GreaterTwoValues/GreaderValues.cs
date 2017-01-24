using System;
namespace GreaterTwoValues
{
    class GreaderValues
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                var first = int.Parse(Console.ReadLine());
                var second = int.Parse(Console.ReadLine());
                int max = GetMaX(first, second);
                Console.WriteLine(max);
            }
            if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char max = GetMax(first, second);
                Console.WriteLine(max);
            }
            if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string max = GetMax(first, second);
                Console.WriteLine(max);
            }
        }

        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0) return first;
            else return second;
        }
        static char GetMax(char first, char second)
        {
            if (first >= second) return first;
            else return second;
        }
        static int GetMaX(int first, int second)
        {
            if (first >= second) return first;
            else return second;
        }
    }
}
