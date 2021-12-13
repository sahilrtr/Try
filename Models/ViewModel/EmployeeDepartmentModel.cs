using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Try.Models.ViewModel
{
    public class EmployeeDepartmentModel
    {
        public List<Department> Department { get; internal set; }
        public List<Employee> Employee { get; internal set; }
        List<Employee> Employees { get; set; }
        List<Department> Departments { get; set; }
    }
}
