using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.Company_Hierarchy.Interface;

namespace _3.Company_Hierarchy.Employees
{
    class Employee : Person, IEmployee
    {
        private decimal salary;
        private string department;

        public Employee(int id, string firstName, string lastName, decimal salary, string department)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative.");
                }

                this.salary = value;
            }
        }

        public string Department
        {
            get { return this.department; }
            set
            {
                if (value != "Production" && value != "Accounting" && value != "Sales" && value != "Marketing")
                {
                    throw new AggregateException("Invalid Department.");
                }

                this.department = value;
            }
        }

        public override string ToString()
        {
            StringBuilder print = new StringBuilder();
            print.AppendFormat("- {0} {1} Id: {2} \n\r  Salary: {3}\n\r  Department: {4}", this.FirstName, this.LastName, this.Id, this.Salary, this.Department);

            return print.ToString();
        }
    }

}
