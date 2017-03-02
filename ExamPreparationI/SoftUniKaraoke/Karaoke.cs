namespace SoftUniKaraoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Karaoke
    {
        public static void Main()
        {
            var database = new Dictionary<string, List<string>>();

            var parcipiant = Console.ReadLine()
                                    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

            var songsIn = Console.ReadLine()
                                 .Split(',')
                                 .ToArray();
            var songs = (from s in songsIn
                         select s.Trim()).ToArray();
            while (true)
            {
                var par = Console.ReadLine()
                                  .Split(',')
                                  .ToArray();
                var parcSongAlards = (from p in par
                                      select p.Trim()).ToArray();
                var performer = parcSongAlards[0];
                if (performer == "dawn") break;
                var song = parcSongAlards[1];
                var award = parcSongAlards[2];
                if (parcipiant.Contains(performer) && songs.Contains(song))
                {
                    if (!database.ContainsKey(performer))
                    {
                        database.Add(performer, new List<string>());
                        database[performer].Add(award);
                    }
                    else
                    {
                        if (!database[performer].Contains(award))
                        {
                            database[performer].Add(award);
                        }
                    }
                }
            }


            if (database.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var perf in database.OrderByDescending(a => a.Value.Count))
                {
                    Console.WriteLine(perf.Key + ": " + perf.Value.Count + " awards");
                    foreach (var item in perf.Value.OrderBy(a => a))
                    {
                        Console.WriteLine("--" + item);
                    }
                }
            }

        }
    }
}
