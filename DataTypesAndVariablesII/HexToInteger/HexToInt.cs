using System;
namespace HexToInteger
{
    class HexToInt
    {
        static void Main(string[] args)
        {
            string hexadecimal = Console.ReadLine();
            int convToInt = Convert.ToInt32(hexadecimal, 16);
            Console.WriteLine(convToInt);
        }
    }
}
