using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_in_C_
{
    internal class StudentsFilterByMarks
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
                var res = students.Where(x => x.Marks < 40).ToList();
                foreach (Student student in res)
                {
                    Console.WriteLine($"student name:{student.Name} - Marks:{student.Marks}");
                }
                Console.ReadLine();
            }
        }
    }
}
