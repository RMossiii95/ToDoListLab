using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListLab2.Models
{
    public class ToDoDAL
    {
        public List<ToDo> GetToDos()
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "select * from ToDo";
                connect.Open(); ;
                List<ToDo> toDos = connect.Query<ToDo>(sql).ToList();
                connect.Close();
                return toDos;
            }
        }

        public ToDo GetToDo(int id)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "select * from todo where id=" + id;
                connect.Open(); ;
                ToDo todo = connect.Query<ToDo>(sql).ToList().First();
                connect.Close();
                return todo;
            }
        }
        public void AddToDo(ToDo t)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = $"insert into employee values(0, '{t.Name}', {t.HoursNeeded}, {t.IsCompleted})";
                connect.Open(); ;
                connect.Query<ToDo>(sql);
                connect.Close();
            }
        }
        public void EditToDo(ToDo t)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = $"update todos set " +
                    $"name = '{t.Name}', description = '{t.Description}', assignedto = {t.AssignedTo}, hoursneeded = {t.HoursNeeded}, iscompleted = {t.IsCompleted} where id = {t.Id};";
                connect.Open();
                connect.Query(sql); 
                connect.Close();
            }
        }
    }
}
