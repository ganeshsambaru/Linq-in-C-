using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_in_C_
{
    internal class TopPerformerFinder
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                List<Student> students = new List<Student>
                {
                    new Student { Name = "Ganesh", Marks = 95 },
                    new Student { Name = "Suresh", Marks = 90 },
                    new Student { Name = "Mahesh", Marks = 85 },
                    new Student { Name = "Kiran", Marks = 80 },
                    new Student { Name = "Gita", Marks = 75 }
                };

                var topper = students.ElementAt(0);

                Console.WriteLine($"Topper:{topper.Name} - Marks:{topper.Marks}");

                var ThirdRanker = students.ElementAt(2);

                Console.WriteLine($"ThirdRanker:{ThirdRanker.Name} - Marks:{ThirdRanker.Marks}");

                var TenthRanker = students.ElementAtOrDefault(9);

                if(TenthRanker != null)
                {
                    Console.WriteLine($"10th Ranker:{TenthRanker.Name} - Marks:{TenthRanker.Marks}");
                }
                else
                {
                    Console.WriteLine("No student Found");
                }
                Console.WriteLine($"Total Students: {students.Count}");
                Console.ReadLine();
            }
        }
    }
}
