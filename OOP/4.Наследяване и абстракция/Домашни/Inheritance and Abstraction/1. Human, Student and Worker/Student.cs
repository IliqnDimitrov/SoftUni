using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Human__Student_and_Worker
{
    class Student : Human
    {
        private long facultyNumber;

        public long FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value < 10000 || value > 9999999999)
                {
                    throw new IndexOutOfRangeException("faculty number must be from 5-10 digits long");
                }
                this.facultyNumber = value;
            }
        }

        public Student(string firstName, string lastName, long facultyNumber)
            :base(firstName,lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} faculty number: {2}", this.FirstName, this.LastName, this.FacultyNumber);
        }
    }
}
