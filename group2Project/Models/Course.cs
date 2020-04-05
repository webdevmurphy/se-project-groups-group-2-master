using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace group2Project.Models
{
    public class Course
    {

        private String courseName;
        private List<Question> questions;
        private Boolean isSelected;

        public string Id;
        public string name { get; set; }

        //Default constructor
        public Course()
        {
            Random rand = new Random();
            this.name = "";
            this.Id = rand.Next(100, 999).ToString();
            questions = new List<Question>();
        }

        //Overloaded constructor with only course name. Should generate a random ID if none is specified
        public Course(String courseName)
        {
            Random rand = new Random();
            this.Id = (rand.Next(100, 999)).ToString();
            SetCourseName(courseName);            this.questions = new List<Question>();
        }

        //overloaded constructor with name and ID.
        public Course(String courseName, string ID)
        {
            this.courseName = courseName;
            this.Id = ID;
            this.questions = new List<Question>();
        }

        //overloaded constructor with name and Questions.
        public Course(String courseName, List<Question> Questions)
        {
            this.courseName = courseName;
            Random rand = new Random();
            this.Id = (rand.Next(100, 999)).ToString();
            this.questions = Questions;
        }

        //Fully overloaded constructor
        public Course(String courseName, string ID, List<Question> Questions)
        {
            this.courseName = courseName;
            this.Id = ID;
            this.questions = Questions;
        }
        //Add a question to the list
        public void AddQuestion(Question q)
        {
            questions.Add(q);
        }

        //Converts this Course object into a Json string
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

        //////getters and setters only below this line//////
        public String GetCourseName() { return this.courseName; }
        public string GetID() { return this.Id; }
        public List<Question> GetQuestions() {
            if (this.questions != null)
            {
                return this.questions;
            }
            else 
            {
                return null;
            }                     
        }

        public Boolean GetIsSelected() { return this.isSelected; }
        public void SetCourseName(String coursename) { courseName = coursename; }
        public void SetID(string ID) { this.Id = ID; }
        public void SetQuestionList(List<Question> questions) { this.questions = questions; }

        public void SetIsSelected(Boolean IsSelected) { this.isSelected = IsSelected; }

        /*public String getFirstName() { return this.firstName; }
        public String getLastName() { return this.lastName; }
        public String getUserName() { return this.userName; }
        public int getPhoneNumber() { return this.phoneNumber; }
        public String getPassword() { return this.password; }
        public void setFirstName(String firstname) { this.firstName = firstname; }
        public void setLastName(String lastname) { this.lastName = lastname; }
        public void setUserName(String username) { this.userName = username; }
        public void setPhoneNumber(int phonenumber) { this.phoneNumber = phonenumber; }
        public void setPassword(String password) { this.password = password; }*/

    }
}

