using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListLab2.Models;

namespace ToDoListLab2.Controllers
{
    public class ToDoController : Controller
    {
        ToDoDAL tddb = new ToDoDAL();
        EmployeeDAL eDAL = new EmployeeDAL();
        public IActionResult CreateToDo()
        {
            ToDo t = new ToDo();
            t.Name = "Mow Lawn";
            t.IsCompleted = false;
            t.HoursNeeded = 1.5f;

            tddb.AddToDo(t);
            return RedirectToAction("Index", "Employee");
        }
        public IActionResult AssignTask()
        {
            EmployeeTaskViewModel em = new EmployeeTaskViewModel();
            return View(em);
        }
        [HttpPost]
        public IActionResult AssignTask(int toDoId, int employeeId)
        {
            Assignment a = new Assignment();
            a.EmployeeId = employeeId;
            a.ToDoId = toDoId;
            AssignmentDAL ad = new AssignmentDAL();
            ad.CreateAssignment(a);
            return RedirectToAction("Index", "Employee");
        }
        
        public IActionResult Edit(int id)
        {
            ToDo t = tddb.GetToDo(id);
            t.Employees = eDAL.GetEmployees();
            return View(t);
        }
        [HttpPost]
        public IActionResult Edit(ToDo t)
        {
            if (ModelState.IsValid)
            {
                tddb.EditToDo(t);
                return RedirectToAction("index");
            }
            return View(t);
        }
    }
}
