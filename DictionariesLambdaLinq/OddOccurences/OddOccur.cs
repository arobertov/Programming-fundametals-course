namespace OddOccurences
{
using System;
using System.Collections.Generic;
using System.Linq;
    public class OddOccur
    {
       public static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split(' ').ToList();
            var toWord = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!toWord.ContainsKey(word))
                {
                    toWord[word] = 0;
                }
                toWord[word]++;
            }
            var result = new List<string>();
            foreach (var item in toWord)
            {
                if (item.Value%2!=0)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
