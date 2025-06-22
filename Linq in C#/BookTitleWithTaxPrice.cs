using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_in_C_
{
    internal class BookTitleWithTaxPrice
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
                    new Book { Title = "The Pragmatic Programmer", Price = 600 },
                    new Book { Title = "Head First C#", Price = 480 },
                    new Book { Title = "ASP.NET Core in Action", Price = 520 }
                };

                var res = books.Select(b => new Book { Title = b.Title,Price = b.Price * 1.18m });
                Console.WriteLine("Books Prices");
                foreach (var book in res)
                {
                    Console.WriteLine($"Book:{book.Title} - FinalPrice:₹{book.Price:F2}");
                }
                Console.ReadLine();
            }
        }
    }
}
