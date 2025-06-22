using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_in_C_
{
    internal class LastBookThrowsException
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

                try
                {
                    var res = books.Where(p => p.Price < 100).Last();

                    Console.WriteLine("Books Under 100 Rupees");
                    Console.WriteLine("----------------------");

                    Console.WriteLine($"Book Found:{res.Title} - Price:₹{res.Price}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Thank You");
                }
            }
        }
    }
}
