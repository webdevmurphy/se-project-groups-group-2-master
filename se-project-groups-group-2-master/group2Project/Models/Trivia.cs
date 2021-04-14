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

        //Default constructor
        public Trivia()
        {
     
        }
    }   
}

