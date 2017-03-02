using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Files
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var file = new List<FileName>();
            for (int i = 0; i < n; i++)
            {
                
                var input = Console.ReadLine().Split('\\').ToArray();
                var splitSize = input.Last().Split(';').ToArray();
                var files = new FileName();
                files.Root = input[0];
                files.File = splitSize[0];
                files.Sise = splitSize.Last();
                file.Add(files);
            }
            var command = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            var fileExt = command[0];
            var root = command[2];
            var query = file.Where(a => a.File.EndsWith(fileExt) && a.Root == root)
                                     .OrderByDescending(a => a.Sise)
                                     .ThenBy(a => a.File).ToList();
            if (!query.Any())
            {
                Console.WriteLine("No");
            }
            foreach (var item in query)
            {
                Console.WriteLine($"{item.File} - {item.Sise} KB");
            }
        }
    }
    class FileName
    {
        public string Root { get; set; }
        public string File { get; set; }
        public string Sise { get; set; }
    }
}
