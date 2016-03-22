using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.Class_Student;

namespace _7.Filter_Students_by_Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = Student.StudentiDB();

            var filterStudents =
                students.Where(
                    std => std.Phone.StartsWith("02") || std.Phone.StartsWith("+3592") || std.Phone.StartsWith("+359 2"));

            foreach (var student in filterStudents)
            {
                Console.WriteLine(
                    "First Name: {0}, Last Name: {1}, Age: {2}, FacultyNumber: {3}, Phone: {4}, Email: {5}, Marks: {6}, GroupNumber: {7}",
                    student.FirstName, student.LastName, student.Age, student.FacultyNumber, student.Phone,
                    student.Email, string.Join(", ", student.Marks), student.GroupNumber);
            }
        }
    }
}
