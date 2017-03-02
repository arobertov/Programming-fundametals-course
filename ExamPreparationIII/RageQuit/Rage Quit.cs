using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RageQuit
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine().ToUpper();
            string pattern = @"([^\d]+)(\d+)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            StringBuilder rage = new StringBuilder();
            foreach (Match match in matches)
            {
                var message = match.Groups[1].Value;
                var mult = long.Parse(match.Groups[2].Value);
                for (long i = 0; i < mult; i++)
                {
                  rage.Append(message);
                }
                
            }
            var count = rage.ToString().Distinct().Count();
           
            Console.WriteLine("Unique symbols used: {0}", count);
            Console.WriteLine(rage); 
        }
    }
}
