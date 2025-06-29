using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_in_C_
{
    internal class FindStudentWithExactMarks
    {
        public class Student
        {
            public string Name { get; set; }
            public int Marks { get; set; }
        }
        public class Program
        {
            public static void Main(string[] args)
            {
                List<Student> students = new List<Student>
                {
                  new Student { Name = "Ganesh", Marks = 85 },
                  new Student { Name = "Suresh", Marks = 70 },
                  new Student { Name = "Mahesh", Marks = 85 },
                  new Student { Name = "Kiran",  Marks = 60 },
                  new Student { Name = "Ramesh", Marks = 45 }
                };

                var exactOne = students.SingleOrDefault(m => m.Marks == 70);

                if (exactOne != null)
                {
                    Console.WriteLine($"SingleOrDefault - Found: {exactOne.Name} - Marks: {exactOne.Marks}");
                }
                else
                {
                    Console.WriteLine("SingleOrDefault - No student found with 70 marks");
                }

                Console.WriteLine();

                // ❌ Unsafe usage: Single (2 students with 85 marks, will throw)
                try
                {
                    var duplicate = students.Single(s => s.Marks == 85);
                    Console.WriteLine($"Single - Found: {duplicate.Name} - Marks: {duplicate.Marks}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Single - Exception occurred:");
                    Console.WriteLine(ex.Message);
                }

                Console.ReadLine();
            }
        }
    }
}
