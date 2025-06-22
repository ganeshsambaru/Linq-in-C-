using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_in_C_
{
    internal class TopStudentsUsingTake
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
                // Take 3 marks
                var res = students.OrderByDescending(b => b.Marks).Take(3).ToList();
                Console.WriteLine("Student Marks By Taking First 3 Are:");
                Console.WriteLine("------------------------------------");

                foreach (var student in res)
                {
                    Console.WriteLine($"Student Name:{student.Name} - Student Marks:{student.Marks}");
                }
                // skip 3 marks
                var res1 = students.OrderByDescending(b => b.Marks).Skip(2).ToList();
                Console.WriteLine("Student Marks By Skipping First 2 Are:");
                Console.WriteLine("--------------------------------------");

                foreach (var student in res1)
                {
                    Console.WriteLine($"Student Name:{student.Name} - Student Marks:{student.Marks}");
                }
                Console.ReadLine();
            }
        }
    }
}
