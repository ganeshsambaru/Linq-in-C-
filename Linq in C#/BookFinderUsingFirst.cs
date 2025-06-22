using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_in_C_
{
    internal class BookFinderUsingFirst
    {
        public class Book
        {
            public string Title { get; set; }
            public decimal Price { get; set; }
        }
        public class Program
        {
            public static void Main(string[] args)
            {
                List<Book> books = new List<Book>
                {
                    new Book { Title = "C# in Depth", Price = 750 },
                    new Book { Title = "Pro ASP.NET Core", Price = 680 },
                    new Book { Title = "LINQ Pocket Reference", Price = 320 },
                    new Book { Title = "Clean Code", Price = 450 },
                    new Book { Title = "The Pragmatic Programmer", Price = 600 }
                };

                var res = books.OrderBy(b => b.Price).First();
                Console.WriteLine("First Book");
                Console.WriteLine($"Title: {res.Title}, Price: {res.Price}");


                var res1 = books.FirstOrDefault(b => b.Title == "Mastering C#");

                if(res1 != null)
                {
                    Console.WriteLine($"Found: {res1.Title}, Price: {res1.Price}");
                }
                else
                {
                    Console.WriteLine("Book not found.");
                }

                Console.ReadLine();
            }
        }
    }
}
