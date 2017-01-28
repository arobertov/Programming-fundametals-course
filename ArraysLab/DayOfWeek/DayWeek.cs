using System;

namespace DayOfWeek
{
    class DayWeek
    {
        static void Main(string[] args)
        {
            int numberDay = int.Parse(Console.ReadLine());
            if (numberDay < 1 || numberDay > 7) numberDay = 0;
            string[] nameDay = {"Invalid Day!",
                                "Monday",
                                "Tuesday",
                                "Wednesday",
                                "Thursday",
                                "Friday",
                                "Saturday",
                                "Sunday"};
            Console.WriteLine(nameDay[numberDay]);                        
        }
    }
}
