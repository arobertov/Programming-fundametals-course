using System;
class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        PrintTopBottomRow(n);
        PrintMidlleRow(n);
        PrintTopBottomRow(n);
    }

    private static void PrintMidlleRow(int n)
    {
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write("-");
            for (int p = 1; p < n; p++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
    }

    private static void PrintTopBottomRow(int n)
    {
        Console.WriteLine(new string('-', 2 * n));
    }
}

