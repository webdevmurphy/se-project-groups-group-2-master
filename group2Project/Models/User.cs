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
        public string password { get; set; }
        public Boolean isTeacher { get; set; }

        public User()
        {

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
    }
}
