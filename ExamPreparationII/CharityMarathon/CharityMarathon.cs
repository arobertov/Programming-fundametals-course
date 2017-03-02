namespace CharityMarathon
{
using System;
    public class CharityMarathon
    {
       public static void Main()
        {
            double daysCount = double.Parse(Console.ReadLine());
            double runnersCount = double.Parse(Console.ReadLine());
            double averageLaps = double.Parse(Console.ReadLine());
            double trackLenght = double.Parse(Console.ReadLine());
            double capacityTrack = double.Parse(Console.ReadLine());
            double moneyKilometer = double.Parse(Console.ReadLine());

            var maximumRuners = daysCount * capacityTrack;
            var totalRuners = 0.0;
            if (maximumRuners >= runnersCount)
            {
                totalRuners = runnersCount;
            }
            else
            {
                totalRuners = maximumRuners;
            }
            var totalMeters = totalRuners * trackLenght * averageLaps;
            var moneyRaised = (totalMeters / 1000) * moneyKilometer;
            Console.WriteLine("Money raised: {0:F2}", moneyRaised);
        }
    }
}
