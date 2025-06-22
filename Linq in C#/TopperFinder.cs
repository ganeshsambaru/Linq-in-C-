using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_in_C_
{
    internal class TopperFinder
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
                    new Student { Name = "Suresh", Marks = 38 },
                    new Student { Name = "Mahesh", Marks = 92 },
                    new Student { Name = "Kiran", Marks = 38 },
                    new Student { Name = "Ramesh", Marks = 70 },
                    new Student { Name = "Gita", Marks = 20 },
                    new Student { Name = "Lalitha", Marks = 44 },
                    new Student { Name = "Arjun", Marks = 20 }
                };

                // Using First() - assuming list has at least one student
                var topper = students.OrderByDescending(s => s.Marks).First();
                Console.WriteLine("Topper:");
                Console.WriteLine($"Name: {topper.Name}, Marks: {topper.Marks}");

                // Using FirstOrDefault() to safely find a student with 100 marks
                var hundredMarkStudent = students.FirstOrDefault(s => s.Marks == 100);
                Console.WriteLine("\nSearching for a student with exactly 100 marks:");
                if (hundredMarkStudent != null)
                {
                    Console.WriteLine($"Name: {hundredMarkStudent.Name}, Marks: {hundredMarkStudent.Marks}");
                }
                else
                {
                    Console.WriteLine("No student scored exactly 100 marks.");
                }

                Console.ReadLine();
            }
        }
    }
}
