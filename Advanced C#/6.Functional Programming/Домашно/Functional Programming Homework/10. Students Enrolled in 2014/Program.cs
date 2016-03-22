using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.Class_Student;

namespace _10.Students_Enrolled_in_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = Student.StudentiDB();

            var enrollStudents = students.Where(std => std.FacultyNumber.ToString().EndsWith("14"));

            foreach (var student in enrollStudents)
            {
                Console.WriteLine(
                    "First Name: {0}, Last Name: {1}, Age: {2}, FacultyNumber: {3}, Phone: {4}, Email: {5}, Marks: {6}, GroupNumber: {7}",
                    student.FirstName, student.LastName, student.Age, student.FacultyNumber, student.Phone,
                    student.Email, string.Join(", ", student.Marks), student.GroupNumber);
            }
        }
    }
}
