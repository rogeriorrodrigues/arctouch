using System;
using Newtonsoft.Json;

namespace movies.Models
{
    public class SpokenLanguage
    {
        public SpokenLanguage()
        {
        }

        [JsonProperty("iso_639_1")]
        public string iso_639_1 { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
    }
}
