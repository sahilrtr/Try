using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Try.Models;
using Try.Models.Respository;
using Try.Models.ViewModel;

namespace Try.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployee employee;
        public EmployeeController(IEmployee _employee)
        {
            employee = _employee;
        }
        public IActionResult Index()
        {
            //var emps= employee.GetEmployees();
            // var dept = employee.GetDepartments();
            // EmployeeDepartmentModel obj = new EmployeeDepartmentModel()
            // {
            //     Employee = emps,
            // Department=dept
            // };
            // return View(obj);
            var prds = employee.GetEmployeeViews();
            return View(prds);
        }
        public IActionResult Create()
        {
            var cats = employee.GetDepartments();
            ViewBag.cats = cats;
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateEmployee employees)
        {
            employee.PostEmployee(employees);  
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            employee.DeleteProduct(id);
            return RedirectToAction("Index");
        }
    
        public IActionResult Update(int id)
        {
           return View( employee.GetProductById(id));

        }
        [HttpPost]
        public IActionResult Update(Employee employees)
        {
            employee.UpdateEmployee(employees);
            return RedirectToAction("Index");
        }
        public IActionResult AddDepartment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateDepartment(Department departments)
        {
            employee.CreateDepartment(departments);
            return RedirectToAction("Index");
        }

    }
}
