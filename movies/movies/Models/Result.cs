using System;
using Newtonsoft.Json;

namespace movies.Models
{
    public class Result
    {
        public Result()
        {
        }

        [JsonProperty("vote_count")]
        public int vote_count { get; set; }

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("video")]
        public bool video { get; set; }

        [JsonProperty("vote_average")]
        public double vote_average { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("popularity")]
        public double popularity { get; set; }

        [JsonProperty("poster_path")]
        public string poster_path { get; set; }

        [JsonProperty("original_language")]
        public string original_language { get; set; }

        [JsonProperty("original_title")]
        public string original_title { get; set; }

        [JsonProperty("genre_ids")]
        public int[] genre_ids { get; set; }

        [JsonProperty("backdrop_path")]
        public string backdrop_path { get; set; }

        [JsonProperty("adult")]
        public bool adult { get; set; }

        [JsonProperty("overview")]
        public string overview { get; set; }

        [JsonProperty("release_date")]
        public DateTime release_date { get; set; }

        [JsonIgnore]
        public string PosterLittle
        {
            get
            {
                string poster = "https://image.tmdb.org/t/p/w92" + poster_path;


                return poster;
            }
        }

        [JsonIgnore]
        public string PosterBig
        {
            get
            {
                string poster = "https://image.tmdb.org/t/p/w300" + poster_path;


                return poster;
            }
        }

        [JsonIgnore]
        public string Backdrop
        {
            get
            {
                string back = "https://image.tmdb.org/t/p/w300" + backdrop_path;


                return back;
            }
        }
    }
}
