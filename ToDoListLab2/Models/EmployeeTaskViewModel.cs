using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListLab2.Models
{
    public class EmployeeTaskViewModel
    {
        public List<ToDo> ToDos { get; set; }
        public List<Employee> Employees { get; set; }

        public EmployeeTaskViewModel()
        {
            ToDoDAL tdDAL = new ToDoDAL();
            EmployeeDAL eDAL = new EmployeeDAL();
            ToDos = tdDAL.GetToDos();
            Employees = eDAL.GetEmployees();
        }
    }
}
