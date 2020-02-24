using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group2Project.Models
{
    class Question
    {
        private string question;
        private string answer;
       
        public Question()
        {

        }

        public Question(string question, string answer)
        {
            this.question = question;
            this.answer = answer;
        }
    }
}
