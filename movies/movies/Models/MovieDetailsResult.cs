using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace movies.Models
{
    public class Genre
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
    }

    public class ProductionCompany
    {

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("logo_path")]
        public object logo_path { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("origin_country")]
        public string origin_country { get; set; }
    }

    public class ProductionCountry
    {

        [JsonProperty("iso_3166_1")]
        public string iso_3166_1 { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
    }

    public class SpokenLanguage
    {

        [JsonProperty("iso_639_1")]
        public string iso_639_1 { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
    }

    public class MovieDetailsResult
    {

        [JsonProperty("adult")]
        public bool adult { get; set; }

        [JsonProperty("backdrop_path")]
        public string backdrop_path { get; set; }

        [JsonProperty("belongs_to_collection")]
        public object belongs_to_collection { get; set; }

        [JsonProperty("budget")]
        public int budget { get; set; }

        [JsonProperty("genres")]
        public IList<Genre> genres { get; set; }

        [JsonProperty("homepage")]
        public object homepage { get; set; }

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("imdb_id")]
        public string imdb_id { get; set; }

        [JsonProperty("original_language")]
        public string original_language { get; set; }

        [JsonProperty("original_title")]
        public string original_title { get; set; }

        [JsonProperty("overview")]
        public string overview { get; set; }

        [JsonProperty("popularity")]
        public double popularity { get; set; }

        [JsonProperty("poster_path")]
        public string poster_path { get; set; }

        [JsonProperty("production_companies")]
        public IList<ProductionCompany> production_companies { get; set; }

        [JsonProperty("production_countries")]
        public IList<ProductionCountry> production_countries { get; set; }

        [JsonProperty("release_date")]
        public DateTime release_date { get; set; }

        [JsonProperty("revenue")]
        public int revenue { get; set; }

        [JsonProperty("runtime")]
        public int runtime { get; set; }

        [JsonProperty("spoken_languages")]
        public IList<SpokenLanguage> spoken_languages { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("tagline")]
        public string tagline { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("video")]
        public bool video { get; set; }

        [JsonProperty("vote_average")]
        public double vote_average { get; set; }

        [JsonProperty("vote_count")]
        public int vote_count { get; set; }

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
