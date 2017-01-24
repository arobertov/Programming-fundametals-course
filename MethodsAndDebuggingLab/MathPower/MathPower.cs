using System;
class Program
{
    static void Main()
    {
        double baseNumber = double.Parse(Console.ReadLine());
        double exponenta = double.Parse(Console.ReadLine());
        Console.WriteLine(RaiseToPower(baseNumber, exponenta));
    }

    private static double RaiseToPower(double baseNumber, double exponenta)
    {
        double result = baseNumber;
        for (int i = 1; i < exponenta; i++)
        {
            result = result * baseNumber;
        }
        return result;
    }
}

