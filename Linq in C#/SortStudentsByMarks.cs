using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_in_C_
{
    internal class SortStudentsByMarks
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
                     new Student { Name = "Suresh", Marks = 35 },
                     new Student { Name = "Mahesh", Marks = 92 },
                     new Student { Name = "Kiran", Marks = 38 },
                     new Student { Name = "Ramesh", Marks = 70 },
                     new Student { Name = "Gita", Marks = 28 },
                     new Student { Name = "Lalitha", Marks = 44 },
                     new Student { Name = "Arjun", Marks = 20 }
                };

                var res = students.OrderBy(m =>m.Marks).ToList();
                var res1 = students.OrderByDescending(m =>m.Marks).ToList();
                Console.WriteLine("Students Sorted By Marks (Low To High)");
                foreach (var student in res)
                {
                    Console.WriteLine($"-{student.Name} - {student.Marks}");
                }
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Students Sorted By Marks (High To Low)");
                foreach (var student in res1)
                {
                    Console.WriteLine($"-{student.Name} - {student.Marks}");
                }
                Console.ReadLine();
            }
        }
    }
}
