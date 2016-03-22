using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.Class_Student;

namespace _9.Weak_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = Student.StudentiDB();

            var weakStudents = students.Where(std => std.Marks.Count(x => x == 2) == 2).Select(std => new
            {
                fullname = std.FirstName + " " + std.LastName,
                std.Marks
            });

            foreach (var student in weakStudents)
            {
                Console.WriteLine("Student: {0}, Marks: {1}", student.fullname, string.Join(", ", student.Marks));
            }
        }
    }
}
