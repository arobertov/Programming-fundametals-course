namespace SinoTheWalker
{
    using System;
    public class SinoWalker
    {
        public static void Main()
        {
            var time = DateTime.Parse(Console.ReadLine());
            var second = double.Parse(Console.ReadLine())%86400;
            var step = double.Parse(Console.ReadLine());
            var hours = ((second/3600)*step);
            var result = time.AddHours(hours);
            Console.WriteLine("Time Arrival: " + result.TimeOfDay);
        }
    }
}