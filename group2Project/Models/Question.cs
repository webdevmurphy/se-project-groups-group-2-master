using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace group2Project.Models
{
    public class Question
    {
        public String question { get; set; }
        public String answer { get; set; }
        public String course { get; set; }

        private List<Answer> a;

        private List<string> answerList;
        //default constructor
        public Question()
        {
     
        }

        public String getQuestion()
        {
            return this.question;
        }

        public Question(String question)
        {
            this.question = question;
        }

        //overloaded constructor with all parameters
        public Question(String question, String answer, String course)
        {
            this.question = question;
            this.course = course;
        }

        public void addAnswer(string answer, Boolean isCorrect)
        {
            Answer b = new Answer(answer, isCorrect);
            if(a == null)
            {
                a = new List<Answer>();
                a.Add(b);
            } else
            a.Add(b);
        }

        public List<Answer> GetAnswers()
        {
            return this.a;
        }

        //converts object to JSON string
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    public class Answer : Question
    {
        private Boolean isCorrect;

        public Answer()
        {

        }

        public Answer(String answer)
        {
            this.answer = answer;
        }

        public Answer(String answer, Boolean isCorrect)
        {
            this.answer = answer;
            this.isCorrect = isCorrect;
        }

        public String getAnswer()
        {
            return this.answer;
        }

        public Boolean IsCorrect()
        {
            return this.isCorrect;
        }        
    }
}
