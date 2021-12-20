using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListLab2.Models;

namespace ToDoListLab2.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDAL dbEmployee = new EmployeeDAL();
        ToDoDAL dbToDo = new ToDoDAL();

        public IActionResult Index()
        {
            EmployeeTaskViewModel etvm = new EmployeeTaskViewModel();
            return View(etvm);
        }
        public IActionResult Details(int id)
        {
            Employee e = dbEmployee.GetEmployee(id);
            return View(e);
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult AddEmployee()
        {
            dbEmployee.AddEmployee(e);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            Employee e = dbEmployee.GetEmployee(id);
            if (e != null)
            {
                return View(e);
            }
            else
            {
                return RedirectToAction("Invalid ID", id);
            }
        }
        [HttpPost]
        public IActionResult Edit(Employee e)
        {
            if (ModelState.IsValid)
            {
                dbEmployee.UpdateEmployee(e);
                return RedirectToAction("Index");
            }
            return View(e);
        }
        public IActionResult Delete(int id)
        {
            Employee e = dbEmployee.GetEmployee(id);
            return View(e);
        }
        public IActionResult DeleteFromAll(int id)
        {
            dbEmployee.DeleteEmployee(id);
            return RedirectToAction("Index");
        }
    }
}
