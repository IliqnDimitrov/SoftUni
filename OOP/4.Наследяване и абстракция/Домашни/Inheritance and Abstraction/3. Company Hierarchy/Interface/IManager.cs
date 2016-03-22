using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.Company_Hierarchy.Employees;

namespace _3.Company_Hierarchy.Interface
{
    interface IManager
    {
        List<Employee> Employees { get; set; }
    }
}
