using System;
namespace IntToASCII
{
    class IntToASCII
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());

            for (int i = start; i <= stop; i++)
            {
                char print = Convert.ToChar(i);
                Console.Write(print + " ");
            }

        }
    }
}
