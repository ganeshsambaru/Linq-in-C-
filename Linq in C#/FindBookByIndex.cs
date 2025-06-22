using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_in_C_
{
    internal class FindBookByIndex
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

                Console.WriteLine("Enter Index Number");
                int index = int.Parse(Console.ReadLine());

                var res = books.ElementAt(index);

                Console.WriteLine($"Book At Index:{res}");
                Console.ReadLine();

            }
        }
    }
}
