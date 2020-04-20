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
    }
}

