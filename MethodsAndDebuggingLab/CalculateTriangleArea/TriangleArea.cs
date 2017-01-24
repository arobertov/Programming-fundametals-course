using System;
class Program
{
    static void Main()
    {
        double wight = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine(GetTriangleArea(wight, height));
    }

    private static double GetTriangleArea(double wight, double height)
    {
        return wight * height / 2;
    }
}

