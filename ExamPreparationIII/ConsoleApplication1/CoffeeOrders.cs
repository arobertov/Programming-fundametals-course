using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace ConsoleApplication1
{
    class CoffeeOrders
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var coffePrice = new List<decimal>();
            for (int i = 0; i < n; i++)
            {
                var priseCapsule = decimal.Parse(Console.ReadLine());
                var date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsulesCount = long.Parse(Console.ReadLine());
                var daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
                var price = priseCapsule * (capsulesCount * daysInMonth);
                coffePrice.Add(price);
            }
            foreach (var item in coffePrice)
            {
                Console.WriteLine($"The price for the coffee is: ${item:F2}");
            }

            Console.WriteLine($"Total: ${coffePrice.Sum():F2}");
        }
    }
}