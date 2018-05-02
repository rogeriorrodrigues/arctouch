using System;
using Newtonsoft.Json;

namespace movies.Models
{
    public class ProductionCompany
    {
        public ProductionCompany()
        {
        }

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("logo_path")]
        public object logo_path { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("origin_country")]
        public string origin_country { get; set; }
    }
}
