using System;
using System.Collections.Generic;
using System.Linq;
namespace BookLibrary
{
    class BookLibrary
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Library lib = new Library();
            lib.Books = new List<Book>(); 
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Book currentBook = new Book();
                currentBook.Title = input[0];
                currentBook.Author = input[1];
                currentBook.Publisher = input[2];
                currentBook.ReleaseDate =DateTime.ParseExact(input[3],"dd.MM.yyyy",null);
                currentBook.ISBN = input[4];
                currentBook.Price = double.Parse(input[5]);
                lib.Books.Add(currentBook);
            }
            var autors = new Dictionary<string, double>();
            foreach (Book book in lib.Books)
            {
                if (!autors.ContainsKey(book.Author))
                {
                    autors.Add(book.Author, book.Price);
                }
                else autors[book.Author] += book.Price;
            }
            foreach (var item in autors.OrderByDescending(a=>a.Value).ThenBy(a=>a.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }

        }
    }
   
   public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
    }
    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
