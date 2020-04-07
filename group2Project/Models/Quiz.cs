using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2Project.Models
{
    class Quiz
    {
        private Question q;
        private Course c;
        private List<Answer> answers;
        
        public Quiz()
        {

        }
        public Quiz(Course q)
        {
            this.c = q;
           // answers = q.GetAnswers();
        }

        public Quiz(Question q)
        {
            this.q = q;
            answers = q.GetAnswers();
        }

        public string getAnswer1()
        {
            return answers[0].getAnswer(); 
        }

        public string getAnswer2()
        {
            return answers[1].getAnswer(); 
        }

        public string getAnswer3()
        {
            return answers[2].getAnswer(); 
        }

        public string getAnswer4()
        {
            return answers[3].getAnswer(); 
        }


    }
}
