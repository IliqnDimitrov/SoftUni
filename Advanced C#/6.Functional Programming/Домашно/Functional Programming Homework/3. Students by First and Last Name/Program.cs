using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.Class_Student;

namespace _3.Students_by_First_and_Last_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = Student.StudentiDB();

            //LINQ
            var sortedStudents = students.Where(std => std.FirstName[0] < std.LastName[0]);

            //Query Expression Syntax 
            var sortedStudents2 =
                from std in students
                where std.FirstName[0] < std.LastName[0]
                select std;

            foreach (var student in sortedStudents2)
            {
                Console.WriteLine(
                    "First Name: {0}, Last Name: {1}, Age: {2}, FacultyNumber: {3}, Phone: {4}, Email: {5}, Marks: {6}, GroupNumber: {7}",
                    student.FirstName, student.LastName, student.Age, student.FacultyNumber, student.Phone,
                    student.Email, string.Join(", ", student.Marks), student.GroupNumber);
            }
        }
    }
}
