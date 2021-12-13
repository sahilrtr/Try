using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Try.Models.ViewModel;

namespace Try.Models.Respository
{
    public interface IEmployee
    {
        public List<Employee> GetEmployees();
        public List<Department> GetDepartments();

        public CreateEmployee PostEmployee(CreateEmployee employee);
        Employee GetProductById(int id);
        bool DeleteProduct(int id);
        Employee UpdateEmployee(Employee employee);
        public Department CreateDepartment(Department department);

        List<EmployeeViewModel> GetEmployeeViews();




    }
}
