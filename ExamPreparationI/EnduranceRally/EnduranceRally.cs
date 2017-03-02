namespace EnduranceRally
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public  class EnduranceRally
    {
      public  static void Main()
        {
            var driversName = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            var zones = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            var index = Console.ReadLine().Split().Select(long.Parse).ToArray();
            List<Driver> parcipians = new List<Driver>();
            for (int i = 0; i < driversName.Length; i++)
            {
                var driver = new Driver();
                driver.Name = driversName[i];
                decimal fuel = GetDriverFuel(driversName[i]);
                for (int j = 0; j < zones.Length; j++)
                {
                    bool isCheckpoint = GetCheckpoint(j, index);
                    if (isCheckpoint)
                    {
                        fuel = zones[j] + fuel;
                    }
                    else
                    {
                        fuel= fuel-zones[j];
                    }
                    driver.Fuel = fuel;
                    driver.Zone = j;
                    if (fuel <= 0) break;
                }
                parcipians.Add(driver);
            }
            foreach (var item in parcipians)
            {
                if (item.Fuel>0)
                {
                    Console.WriteLine($"{item.Name} - fuel left {item.Fuel:F2}");
                }
                else
                {
                    Console.WriteLine($"{item.Name} - reached {item.Zone}");
                }
            }
        }

        private static bool GetCheckpoint(int j, long[] index)
        {
            bool result = false;
            for (int x = 0; x < index.Length; x++)
            {
                if (j==index[x])
                {
                    result = true;
                }
            }
            return result;
        }

        private static decimal GetDriverFuel(string driver)
        {
            char firstLetter = driver[0];
            return Convert.ToInt32(firstLetter);
        }
    }
    public class Driver
    {
       public string Name { get; set; }
       public int Zone { get; set; }
       public decimal Fuel { get; set; }
    }
}
