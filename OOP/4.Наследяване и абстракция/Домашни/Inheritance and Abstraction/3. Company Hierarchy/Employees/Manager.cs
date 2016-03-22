using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.Company_Hierarchy.Interface;

namespace _3.Company_Hierarchy.Employees
{
    class Manager : Employee, IManager
    {
        public Manager(int id, string firstName, string lastName, decimal salary, string department, List<Employee> employyees)
            : base(id, firstName, lastName, salary, department)
        {
            this.Employees = employyees;
        }

        public List<Employee> Employees { get; set; }

        public override string ToString()
        {
            StringBuilder print = new StringBuilder();
            print.AppendFormat("{0} {1} Id: {2} \n\rSalary: {3}\n\rDepartment: {4}\n\rEmployee:\n\r", this.FirstName, this.LastName, this.Id, this.Salary, this.Department);
            foreach (var project in this.Employees)
            {
                print.AppendLine(project.ToString());
            }

            return print.ToString();
        }
    }

}
