using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDessert
{
    class SweetDessert
    {
        static void Main()
        {
            var money = double.Parse(Console.ReadLine());
            var guests = int.Parse(Console.ReadLine());
            var bananas= double.Parse(Console.ReadLine())*2;
            var eggs = double.Parse(Console.ReadLine())*4;
            var berries = double.Parse(Console.ReadLine())*0.2;

            int sets =0;
            if (guests%6==0)
            {
                sets = guests / 6;
            }
            else
            {
                sets = (guests / 6) + 1;
            }
            var totalPrice = (bananas + eggs + berries) * sets;
            if (money>=totalPrice)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:F2}lv.");
            }
            else
            {
               var total= totalPrice - money;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {total:F2}lv more.");
            }
        }
    }
}
