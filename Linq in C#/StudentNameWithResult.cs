using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Linq_in_C_
{
    public class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
    }
    internal class StudentNameWithResult
    {
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

                var res = students.Select(s => new { s.Name,Result = s.Marks >= 40 ? "Pass" : "Fail"});
                Console.WriteLine("Student Results");
                foreach (var student in res)
                {
                    Console.WriteLine($"{student.Name} - Result:{student.Result}");
                }
                Console.ReadLine();
            }
        }
    }
}
