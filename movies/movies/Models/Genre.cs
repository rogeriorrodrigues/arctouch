using System;
using Newtonsoft.Json;

namespace movies.Models
{
    public class Genre
    {
        public Genre()
        {
        }

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
    }
}
