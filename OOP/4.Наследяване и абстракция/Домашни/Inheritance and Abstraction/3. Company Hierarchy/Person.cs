using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.Company_Hierarchy.Interface;

namespace _3.Company_Hierarchy
{
    public abstract class Person : IPerson
    {
        private int id;
        private string firstName;
        private string lastName;

        public Person(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id
        {
            get { return this.id; }
            set
            {
                if (value.ToString().Length != 8)
                {
                    throw new ArgumentException("Id shoud be 10 digits long.");
                }

                this.id = value;
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Product name cannot be null or empty.");
                }
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Product name shoud be in range [2 ... 10].");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Product name cannot be null or empty.");
                }
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Product name shoud be in range [2 ... 10].");
                }

                this.lastName = value;
            }
        }
    }

}
