using System;
class Program
{

    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        for (int i = 1; i < n; i++)
        {
            PrintTriangle(1, i);
        }

        PrintTriangle(1, n);

        for (int i = n - 1; i > 0; i--)
        {
            PrintTriangle(1, i);
        }

    }

    private static void PrintTriangle(int start, int end)
    {
        for (int i = 1; i <= end; i++)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }
}

