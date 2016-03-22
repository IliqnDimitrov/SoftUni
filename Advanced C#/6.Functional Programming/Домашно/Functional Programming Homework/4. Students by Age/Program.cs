using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.Class_Student;

namespace _4.Students_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = Student.StudentiDB();

            //LINQ
            var sortedStudents = students.Where(std => std.Age >= 18 && std.Age <= 24).Select(std => new
            {
                std.FirstName,
                std.LastName,
                std.Age
            });

            //Query Expression Syntax
            var sortedStudents2 =
                from std in students
                where std.Age >= 18 && std.Age <= 24
                select new {std.FirstName, std.LastName, std.Age};

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(
                    "First Name: {0}, Last Name: {1}, Age: {2}",
                    student.FirstName, student.LastName, student.Age);
            }
        }
    }
}
