using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListLab2.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public float HoursAvailable { get; set; }
        public string Title { get; set; }
        public List<ToDo> ToDos { get; set; }
    }
}
