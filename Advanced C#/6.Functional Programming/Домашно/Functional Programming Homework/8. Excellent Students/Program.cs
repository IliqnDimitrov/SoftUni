using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.Class_Student;

namespace _8.Excellent_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = Student.StudentiDB();

            var excellentStudents = students.Where(std => std.Marks.Any(m => m == 6)).Select(std => new
            {
                fullname = std.FirstName + " " + std.LastName,
                std.Marks
            });

            foreach (var student in excellentStudents)
            {
                Console.WriteLine("Student: {0}, Marks: {1}", student.fullname, string.Join(", ", student.Marks));
            }
        }
    }
}
