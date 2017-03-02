using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NetherRealms
{
    class NetherRealms
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
            var demons = new List<Demon>();
            for (int i = 0; i < input.Length; i++)
            {
                Demon demon = new Demon();

                string demonName = input[i];
                demon.Name = demonName;
                double health = GetHealth(demonName);
                demon.Health = health;
                decimal damage = GetDamage(demonName);
                demon.Damage = damage;
                demons.Add(demon);
            }
            foreach (var item in demons.OrderBy(a => a.Name))
            {
                Console.WriteLine($"{item.Name} - {item.Health} health, {item.Damage:F2} damage ");
            }
        }

        private static decimal GetDamage(string demonName)
        {
            decimal result = 0;
            Regex regex = new Regex(@"[0-9\.-]+");
            foreach (Match match in regex.Matches(demonName))
            {
                result += Convert.ToDecimal(match.Value);
            }
            result = GetMultiple(demonName,result);
            result = GetDivide(demonName, result);
            return result;
        }

        private static decimal GetDivide(string demonName, decimal result)
        {
            var divide = result;
            Regex regex = new Regex(@"\/");
            foreach (Match match in regex.Matches(demonName))
            {
                divide /= 2;
            }
            return divide;
        }

        private static decimal GetMultiple(string demonName,decimal result)
        {
            var multiple = result;
            Regex regex = new Regex(@"\*");
            foreach (Match match in regex.Matches(demonName))
            {
                multiple*=2;
            }
            return multiple; 
        }

        private static double GetHealth(string demonName)
        {
            Regex regex = new Regex(@"[^0-9-+.\*/]");
                var result = 0;
                foreach(Match match in regex.Matches(demonName))
                {
                    result += Convert.ToChar(match.Value);
                }
            return result;
        }
    }
    public class Demon
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public decimal Damage { get; set; }
    }      
}
