using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Human__Student_and_Worker
{
    abstract class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName 
        {
            get { return this.firstName; }
            set { this.firstName = value; } 
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

    }
}
