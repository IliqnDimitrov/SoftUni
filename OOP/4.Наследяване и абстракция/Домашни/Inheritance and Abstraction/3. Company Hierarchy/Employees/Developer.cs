using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.Company_Hierarchy.Interface;

namespace _3.Company_Hierarchy.Employees
{
    class Developer : RegularEmployee, IDeveloper
    {
        public Developer(int id, string firstName, string lastName, decimal salary, string department, List<Project> projects)
            : base(id, firstName, lastName, salary, department)
        {
            this.Projects = projects;
        }

        public List<Project> Projects { get; set; }

        public override string ToString()
        {
            StringBuilder print = new StringBuilder();
            print.AppendFormat("{0} {1} Id: {2} \n\rSalary: {3}\n\rDepartment: {4}\n\rProjects:\n\r", this.FirstName, this.LastName, this.Id, this.Salary, this.Department);
            foreach (var project in this.Projects)
            {
                print.AppendLine(project.ToString());
            }

            return print.ToString();
        }
    }

}
