using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>
            {
               "Ganesh", "Suresh", "Gopal", "Ravi", "Geetha",
               "Manoj", "Gita", "Kiran", "Gokul", "Lalitha"
            };

            var result = students.Where(x => x.StartsWith("G")).ToList();

            Console.WriteLine("Student Names Start with G");
            foreach ( var student in result )
            {
                Console.WriteLine(student);
            }
            Console.ReadLine();
        }
    }
}
