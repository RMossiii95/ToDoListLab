using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListLab2.Models
{
    public class AssignmentDAL
    {
        public void CreateAssignment(Assignment a)
        {
            using(var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = $"insert into Assignments values(0, {a.EmployeeId}, {a.ToDoId})";
                connect.Open();
                connect.Query<Assignment>(sql);
                connect.Close();
            }
        }
    }
}
