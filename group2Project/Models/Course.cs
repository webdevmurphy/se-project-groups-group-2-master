using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace group2Project.Models
{
    class Course
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public string name { get; set; }

        public Course()
        {
            
        }

        public Course(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
