using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListLab2.Models
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AssignedTo { get; set; }
        public float HoursNeeded { get; set; }
        public bool IsCompleted { get; set; }
        public List<Employee> Employees { get; set; }

    }
}
