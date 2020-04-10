using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2Project.Models
{
    public class User
    {
        public string userName { get; set; }
        public string password;
        public Boolean isTeacher = false;
        public int score;

        private List<Course> CurrentCourses;

        public User()
        {
            this.userName = "";
            this.password = "";
            this.score = 0;
        }

        public User(string username, string password, int score)
        {
            this.userName = username;
            this.password = password;
            this.score = score;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    public class Student : User
    {
        public Student()
        {

        }
    }

    public class Teacher : User
    {
        
        private Boolean isValid;
        private List<String> validKeys;

        public double teacherKey { get; set; }

        public Teacher(double teacherKey)
        {
            this.teacherKey = teacherKey;
        }

        public Boolean isValidKey()
        {
            return false;
        }

        public double getTeacherKey() { return this.teacherKey; }
        public string getUserName() { return this.userName; } // just testing with this, will delete when not being used - Dylan
    }
}
