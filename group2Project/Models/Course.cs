﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace group2Project.Models
{
    class Course
    {
        public string name { get; set; }

        public Course()
        {
            
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }


    }
}
