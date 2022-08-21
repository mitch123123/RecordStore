using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Models
{
    public class ActorSearch
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class KnownFor
        {
            public bool adult { get; set; }
            public string backdrop_path { get; set; }
            public List<int> genre_ids { get; set; }
            public int id { get; set; }
            public string media_type { get; set; }
            public string original_language { get; set; }
            public string original_title { get; set; }
            public string overview { get; set; }
            public string poster_path { get; set; }
            public string release_date { get; set; }
            public string title { get; set; }
            public bool video { get; set; }
            public double vote_average { get; set; }
            public int vote_count { get; set; }
            public string first_air_date { get; set; }
            public string name { get; set; }
            public List<string> origin_country { get; set; }
            public string original_name { get; set; }
        }

        public class Result
        {
            public bool adult { get; set; }
            public int gender { get; set; }
            public int id { get; set; }
            public List<KnownFor> known_for { get; set; }
            public string known_for_department { get; set; }
            public string name { get; set; }
            public double popularity { get; set; }
            public string profile_path { get; set; }
        }

        public class Root
        {
            public int page { get; set; }
            public List<Result> results { get; set; }
            public int total_pages { get; set; }
            public int total_results { get; set; }
        }

        public static Result GetActor(string query)
        {
            using (var http = new HttpClient())
            {
                var endpoint = $"https://api.themoviedb.org/3/search/person?api_key=73321a7b17e84973837c579c8bb62fe7&language=en-US&query={query}&page=1&include_adult=false";
                var result = http.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                var obj = JsonConvert.DeserializeObject<Root>(json);
                var actor= obj.results.First();
                return actor;
            }
        }
        public static List<Result> GetActors(string query)
        {
            using (var http = new HttpClient())
            {
                var endpoint = $"https://api.themoviedb.org/3/search/person?api_key=73321a7b17e84973837c579c8bb62fe7&language=en-US&query={query}&page=1&include_adult=false";
                var result = http.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                var obj = JsonConvert.DeserializeObject<Root>(json);
                return obj.results;
                
            }
        }
    }
}
