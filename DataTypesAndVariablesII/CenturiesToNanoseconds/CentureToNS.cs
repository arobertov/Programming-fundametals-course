using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CenturiesToNanoseconds
{
    class CentureToNS
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int year = centuries * 100;
            int days =(int)Math.Truncate(year * 365.2422);
            ulong hours = (ulong)days * 24;
            ulong minutes = hours * 60;
            ulong secunds = minutes * 60;
            ulong millisecunds = secunds * 1000;
            ulong microsecunds = millisecunds * 1000;
            BigInteger nanosecunds = BigInteger.Multiply(microsecunds, 1000);
            Console.WriteLine($"{centuries} centuries = {year} years = {days} days = {hours} hours = {minutes} minutes = {secunds} seconds = {millisecunds} milliseconds = {microsecunds} microseconds = {nanosecunds} nanoseconds");
        }
    }
}
