using System;
using System.Collections.Generic;
using Newtonsoft.Json;

using System.Windows.Input;

namespace movies.Models
{
    public class MovieResults
    {
        public MovieResults()
        {
        }

        [JsonProperty("page")]
        public int page { get; set; }

        [JsonProperty("total_results")]
        public int total_results { get; set; }

        [JsonProperty("rotal_pages")]
        public int total_pages { get; set; }

        [JsonProperty("results")]
        public Result[] results { get; set; }
    }




}
