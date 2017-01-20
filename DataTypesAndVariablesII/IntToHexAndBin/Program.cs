using System;

namespace IntToHexAndBinary
{
    class IntHexBin
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            var hexadecimal = input.ToString("X");
            string binary = Convert.ToString(input, 2);
            Console.WriteLine(hexadecimal);
            Console.WriteLine(binary);
        }
    }
}
