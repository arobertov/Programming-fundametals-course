namespace WiningTicket
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WiningTicket
    {
        static void Main()
        {
            var tickets = Console.ReadLine()
                .Split(new[] { ' ',',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            for (int i = 0; i < tickets.Length; i++)
            {
                var ticket = new Ticket();
                ticket.Contains = tickets[i];
                if (tickets[i].Length!=20)
                {
                    ticket.Value = "invalid ticket";
                }
                else
                {
                    var substring1 = tickets[i].Substring(0, 10);
                    var substring2 = tickets[i].Substring(10, 10);
                    var pattern = @"[@]{6,9}|[#]{6,9}|[$]{6,9}|[\^]{6,9}";
                    Regex regex = new Regex(pattern);
                    Match text1 = regex.Match(substring1);
                    Match text2 = regex.Match(substring2);
                    var textMatch1 = text1.Groups.Count;
                    var textMatch2 = text2.Groups.Count;
                }
            }
        }
             public class Ticket
        {
            public string Contains { get; set; }
            public string Value { get; set; }
            public string WinSimbol { get; set; }
        }
    }
}
