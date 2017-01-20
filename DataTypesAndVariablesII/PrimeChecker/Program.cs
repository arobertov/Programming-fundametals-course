using System;
namespace PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                bool prime = true;
                for (int div = 2; div <= Math.Sqrt(i); div++)
                {
                    if (i % div == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {prime}");
            }

        }
    }
}
