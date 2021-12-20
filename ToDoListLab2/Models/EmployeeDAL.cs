using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListLab2.Models
{
    public class EmployeeDAL
    {
        public List<Employee> GetEmployees()
        {
            using(var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "select * from employee";
                connect.Open(); ;
                List<Employee> employees = connect.Query<Employee>(sql).ToList();
                connect.Close();
                return employees;
            }
        }

        public Employee GetEmployee(int id)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "select * from employee where id=" + id;
                connect.Open(); ;
                Employee employee = connect.Query<Employee>(sql).ToList().First();
                connect.Close();
                return employee;
            }
        }
        public void AddEmployee(Employee e)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = $"insert into employee values(0, '{e.Name}', {e.HoursAvailable}, '{e.Title}')";
                connect.Open(); ;
                connect.Query<Employee>(sql);
                connect.Close();
            }
        }
        public void UpdateEmployee(Employee e)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                var sql = $"update employees set name = '{e.Name}', hours = {e.HoursAvailable}, title = '{e.Title}', where id = {e.Id}";
                connect.Open();
                connect.Query(sql);
                connect.Close();
            }
        }
        public void DeleteEmployee(int id)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                var sql = $"delete from employees where id = {id}";
                connect.Open();
                connect.Query(sql);
                connect.Close();
            }
        }
    }
}
