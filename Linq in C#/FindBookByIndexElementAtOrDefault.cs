using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_in_C_
{
    internal class FindBookByIndexElementAtOrDefault
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                List<string> books = new List<string>
                {
                    "C# in Depth",
                    "Clean Code",
                    "Pro ASP.NET Core",
                    "LINQ Pocket Reference",
                    "Head First C#"
                };

                Console.WriteLine("Enter Index Number:");
                int index = int.Parse(Console.ReadLine());

                // Use ElementAtOrDefault to prevent exception
                string result = books.ElementAtOrDefault(index);

                if (result != null)
                {
                    Console.WriteLine($"Book at index {index}: {result}");
                }
                else
                {
                    Console.WriteLine($"No book found at index {index}. Please enter an index between 0 and {books.Count - 1}.");
                }

                Console.ReadLine();
            }
        }
    }
}
