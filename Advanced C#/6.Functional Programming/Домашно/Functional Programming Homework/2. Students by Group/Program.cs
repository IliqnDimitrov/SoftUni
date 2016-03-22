using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.Class_Student;

namespace _2.Students_by_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = Student.StudentiDB();

            //LINQ
            var groupedStudents = students.Where(gr => gr.GroupNumber == 2).OrderBy(name => name.FirstName);

            //Query Expression Syntax 
            var groupedStudents2 =
                from std in students
                where std.GroupNumber == 2
                orderby std.FirstName ascending
                select std;

            foreach (var student in groupedStudents)
            {
                Console.WriteLine(
                    "First Name: {0}, Last Name: {1}, Age: {2}, FacultyNumber: {3}, Phone: {4}, Email: {5}, Marks: {6}, GroupNumber: {7}",
                    student.FirstName, student.LastName, student.Age, student.FacultyNumber, student.Phone,
                    student.Email, string.Join(", ",student.Marks), student.GroupNumber);
            }
        }
    }
}
