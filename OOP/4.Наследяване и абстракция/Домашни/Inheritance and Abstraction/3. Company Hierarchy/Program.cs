using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.Company_Hierarchy.Interface;
using _3.Company_Hierarchy.Employees;

namespace _3.Company_Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {

            Developer developer = new Developer(11111111, "Todor", "Yordanov", 5000m, "Production",
                new List<Project> {
                { new Project("Money", DateTime.Parse("12.11.2015"), "This porject makes money!")},
                { new Project("Money2", DateTime.Parse("2.1.2005"), "Moneyyy!")}
                });

            Manager manager = new Manager(12191311, "Yordan", "Todorov", 4000m, "Sales",
            new List<Employee> {
                { new Employee(12191311, "Stoyan", "Dimov", 2000m, "Sales")},
                { new Employee(12191311, "Yordan", "Marinov", 1700m, "Sales")},
                { new Employee(12191311, "Marin", "Todorov", 2300m, "Sales")},
            });

            Manager anotherManager = new Manager(12191398, "Yordan", "Yordanov", 11000m, "Marketing",
            new List<Employee> {
                { new Employee(12191311, "Petar", "Todorov", 4000m, "Marketing")},
                { new Employee(12191311, "Vasil", "Petkov", 3800m, "Marketing")},
                { new Employee(12191311, "Qnko", "Qnkov", 4200m, "Marketing")},
                { new Employee(12191311, "Mancho", "Vasilev", 6000m, "Marketing")}
            });

            SalesEmployee salesEmployee = new SalesEmployee(78873465, "Sancho", "Mancho", 8800m, "Marketing",
            new List<Sale> {
                { new Sale("Very cool software", DateTime.Parse("30.9.15"), 32000m)},
                { new Sale("Very cool software", DateTime.Parse("11.9.15"), 25000m)},
                { new Sale("Cool software", DateTime.Parse("20.9.15"), 10000m)},
                { new Sale("Cool software", DateTime.Parse("3.10.15"), 15000m)}
            });

            List<Employee> employees = new List<Employee>();
            employees.Add(developer);
            employees.Add(manager);
            employees.Add(anotherManager);
            employees.Add(salesEmployee);

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

        }
    }
}
