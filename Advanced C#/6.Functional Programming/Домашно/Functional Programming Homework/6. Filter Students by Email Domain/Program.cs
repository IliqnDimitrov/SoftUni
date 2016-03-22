using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.Class_Student;

namespace _6.Filter_Students_by_Email_Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = Student.StudentiDB();

            var filterStudents = students.Where(std => std.Email.Contains("@abv.bg"));

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
