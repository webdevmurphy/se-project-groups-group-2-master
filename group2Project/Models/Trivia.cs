using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace group2Project.Models
{
    public class Trivia
    {
        public string Question { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public Boolean isAnswer { get; set; }
        public int selAnswer { get; set; }

        //default constructor
        public Trivia()
        {
     
        }

        public String getQuestion()
        {
            return this.Question;
        }

        public Trivia(String question)
        {
            this.Question = question;
        }


        //converts object to JSON string
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }   
    }

