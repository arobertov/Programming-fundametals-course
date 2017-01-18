using System;
class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        char a = (char)('a' + n);
        for (char i = 'a'; i < a; i++)
            for (char b = 'a'; b < a; b++)
                for (char c = 'a'; c < a; c++)
                    Console.WriteLine("{0}{1}{2}", i, b, c);

    }
}