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
        public string question { get; set; }
        public string answer { get; set; }
        public string course { get; set; }

        public Question()
        {
     
        }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
