using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Try.Models.ViewModel;

namespace Try.Models.Respository
{
    public class EmployeeServices:IEmployee
    {
        private ApplicationContext context;
        public EmployeeServices(ApplicationContext _context)
        {
            context = _context;
        }

        public bool DeleteProduct(int id)
        {
            var emp = context.Employees.SingleOrDefault(e => e.Id == id);
            if (emp!=null)
            {
                emp.IsActive = false;
                context.Employees.Update(emp);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Department> GetDepartments()
        {
           var dept = context.Departments.ToList();
            return dept;
        }

        public List<Employee> GetEmployees()
        {
           var emp= context.Employees.Where(e=>e.IsActive==true).ToList();
            return emp;
        }

        public Employee GetProductById(int id)
        {
            var emp = context.Employees.SingleOrDefault(e => e.Id == id && e.IsActive==true);
            return emp;
        }

        public Department CreateDepartment(Department department)
        {
            context.Departments.Add(department);
            context.SaveChanges();
            return department;
        }

        public CreateEmployee PostEmployee(CreateEmployee employee)
        {
            var cat = context.Departments.SingleOrDefault(e => e.Did==employee.DepartmentId);
            var prod = new Employee()
            { 
                
            Name=employee.Name,
            Email=employee.Email,
            Gender=employee.Gender,
            IsActive=employee.IsActive,
            department=cat

            };
            context.Employees.Add(prod);
            context.SaveChanges();
            return employee;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            context.Employees.Update(employee);
            context.SaveChanges();
            return employee;
        }

        public List<EmployeeViewModel> GetEmployeeViews()
        {
            var prods = from prod in context.Employees
                        join
                        cats in context.Departments
                        on prod.department.Did equals cats.Did
                        where prod.IsActive==true
                        select new EmployeeViewModel() 
                        { 
                            Id=prod.Id,
                            Name=prod.Name,
                            Email=prod.Email,
                            Gender=prod.Gender,
                            IsActive=prod.IsActive,
                            DName=cats.DName,
                            Description=cats.Description
                        };
            return prods.ToList();
        }
    }
}
