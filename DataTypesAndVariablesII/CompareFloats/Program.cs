using System;
namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numberA = decimal.Parse(Console.ReadLine());
            decimal numberb = decimal.Parse(Console.ReadLine());
            double diff = (double)Math.Abs(numberA - numberb);
            bool tooBig = true;
            if (diff >= 0.000001) tooBig = false;
            Console.WriteLine(tooBig);
        }
    }
}
