using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
namespace BookLibraryModification
{
    class BookModify
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
                currentBook.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy",CultureInfo.InvariantCulture);
                currentBook.ISBN = input[4];
                currentBook.Price = double.Parse(input[5]);
                lib.Books.Add(currentBook);
            }
            var date = DateTime.ParseExact(Console.ReadLine(),"dd.MM.yyyy",CultureInfo.InvariantCulture);
            foreach (Book book in lib.Books.Where(a=>a.ReleaseDate>date).OrderBy(a=>a.ReleaseDate).ThenBy(a=>a.Title))
            {
                
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate.ToString("dd.MM.yyyy")}");
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


