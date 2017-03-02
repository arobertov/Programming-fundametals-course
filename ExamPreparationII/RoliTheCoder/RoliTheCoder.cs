using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoliTheCoder
{
    class RoliTheCoder
    {
        static void Main()
        {
            var database = new Dictionary<int, Dictionary<string, List<string>>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input.Contains("Time for Code")) break;
                if (!input.Contains("#"))
                {
                    continue;
                }
                else
                {
                    var cmd = input.Split(new[] { " ", "#" }, StringSplitOptions.RemoveEmptyEntries);

                    var id = int.Parse(cmd[0]);
                    var eventName = cmd[1];
                    var parcipiant = cmd.Where(a => a.Contains("@")).ToArray();

                    if (!database.ContainsKey(id))
                    {
                        database.Add(id, new Dictionary<string, List<string>>());
                        database[id].Add(eventName, new List<string>(parcipiant));
                    }
                    else
                    {
                        if (database.ContainsKey(id) && database[id].ContainsKey(eventName))
                        {
                            database[id][eventName].AddRange(parcipiant);
                           database[id][eventName]= database[id][eventName].Distinct().ToList();
                        }
                    }
                }
            }
            foreach (var value in database.OrderByDescending(x => x.Value.Values.Sum(p => p.Count)))
            {
                foreach (var item in value.Value)
                {
                    item.Value.Sort();
                    Console.WriteLine($"{item.Key} - {item.Value.Count}");
                    Console.WriteLine(string.Join("\n", item.Value));
                }
            }
        }
    }
}
