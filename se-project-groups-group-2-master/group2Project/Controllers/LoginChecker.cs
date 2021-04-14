using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using group2Project.DataConnection;
using group2Project.Models;

namespace group2Project.Controllers
{
    class LoginChecker
    {
        public static Boolean CheckIfValid(string username, string password, ref Student refStudent)
        {
            MongoClientConn database = new MongoClientConn("Student");
            List<Student> students = database.LoadRecords<Student>("Student");
            foreach(var student in students)
            {
                if(username == student.UserName && password == student.PassWord)
                {
                    refStudent = student;
                    return true;
                }
            }
            return false;
        }
    }
}
