using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace group2Project.Models
{
    class Question
    {
        public String question { get; set; }
        public String answer { get; set; }
        public String course { get; set; }
        
        //default constructor
        public Question()
        {
     
        }

        //overloaded constructor with all parameters
        public Question(String question, String answer, String course)
        {
            this.question = question;
            this.answer = answer;
            this.course = course;
        }

        //converts object to JSON string
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
