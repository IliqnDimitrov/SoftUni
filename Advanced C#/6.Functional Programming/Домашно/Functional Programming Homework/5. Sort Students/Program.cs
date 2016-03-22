using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.Class_Student;

namespace _5.Sort_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = Student.StudentiDB();

            //LINQ
            var sortedStudents = students.OrderByDescending(std => std.FirstName).ThenByDescending(std => std.LastName);

            //Query Expression Syntax 
            var sortedStudents2 =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(
                    "First Name: {0}, Last Name: {1}, Age: {2}, FacultyNumber: {3}, Phone: {4}, Email: {5}, Marks: {6}, GroupNumber: {7}",
                    student.FirstName, student.LastName, student.Age, student.FacultyNumber, student.Phone,
                    student.Email, string.Join(", ", student.Marks), student.GroupNumber);
            }
        }
    }
}
