using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace group2Project.Models
{

    public class Courses
    {

        public Guid Id { get; set; }
        public string CourseName { get; set; }
        public Trivia courseQuestions { get; set; }

        //Default constructor
        public Courses()
        {
            this.CourseName = "";
        }

        //Overloaded constructor with only course name. Should generate a random ID if none is specified
        public Courses(String courseName)
        {
            CourseName = courseName;         
        }

        public Courses(Trivia q)
        {
        }

        //Add a question to the list
        public void AddQuestion(Trivia q)
        {

        }
    }
}

