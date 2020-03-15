using Newtonsoft.Json;

namespace group2Project.CosmosDemo
{
    internal class Robot
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }
        [JsonProperty(PropertyName = "userName")]
        public string userName { get; set; }

        public string password { get; set; }

        public string phoneNumber { get; set; }


        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}