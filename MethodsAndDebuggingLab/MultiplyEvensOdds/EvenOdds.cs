using System;
namespace MultiplyEvensOdds
{
    class EvenOdds
    {

        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);
            Console.WriteLine(GetOodEvenDigits(n));
        }

        static int GetOodEvenDigits(int n)
        {
            int sumEvents = GetSumEvents(n);
            int sumOod = GetSumOods(n);
            return sumEvents * sumOod;
        }

        private static int GetSumOods(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0) sum += lastDigit;
                n /= 10;
            }
            return sum;
        }

        private static int GetSumEvents(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0) sum += lastDigit;
                n /= 10;
            }
            return sum;
        }
    }
}
