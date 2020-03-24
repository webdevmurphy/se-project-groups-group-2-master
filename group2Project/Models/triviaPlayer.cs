using Newtonsoft.Json;


namespace group2Project.Models
{
    class triviaPlayer
    {

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }
        
        public string userName { get; set; }
        
        public string password { get; set; }

        public string phoneNumber { get; set; }

        public bool IsRegistered { get; set; }

        public void StartTrivia()
        {
            //should start trivia player
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
