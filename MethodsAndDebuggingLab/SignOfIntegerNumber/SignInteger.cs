using System;
class SignInteger
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        PrintSign(n);
    }

    private static void PrintSign(int number)
    {
        if (number > 0)
        {
            Console.WriteLine("The number {0} is positive.", number);
        }
        else if (number < 0)
        {
            Console.WriteLine("The number {0} is negative.", number);
        }
        else
        {
            Console.WriteLine("The number {0} is zero.", number);
        }
    }
}
