using System;
using Newtonsoft.Json;

namespace movies.Models
{
    public class ProductionCountry
    {
        public ProductionCountry()
        {
        }

        [JsonProperty("iso_3166_1")]
        public string iso_3166_1 { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
    }
}
