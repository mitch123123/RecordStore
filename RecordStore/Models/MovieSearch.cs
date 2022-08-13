using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Models
{
    public class MovieSearch
    {//explore movies requests also use this model
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Result
        {
            public bool adult { get; set; }
            public string backdrop_path { get; set; }
            public List<int> genre_ids { get; set; }
            public int id { get; set; }
            public string original_language { get; set; }
            public string original_title { get; set; }
            public string overview { get; set; }
            public double popularity { get; set; }
            public string poster_path { get; set; }
            public string release_date { get; set; }
            public string title { get; set; }
            public bool video { get; set; }
            public double vote_average { get; set; }
            public int vote_count { get; set; }
        }

        public class Root
        {
            public int page { get; set; }
            public List<Result> results { get; set; }
            public int total_pages { get; set; }
            public int total_results { get; set; }
        }

        public static List<Result> GetMoviesByName(string query)
        {
            using (var http = new HttpClient())
            {
                var endpoint = $"https://api.themoviedb.org/3/search/movie?api_key=73321a7b17e84973837c579c8bb62fe7&query={query}";
                var result = http.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                var obj = JsonConvert.DeserializeObject<Root>(json);
                return obj.results;
            }
        }
        public static List<Result> GetMoviesByActor(string query)
        {
            var actor = ActorSearch.GetActor(query);
            using (var http = new HttpClient())
            {
                var endpoint = $"https://api.themoviedb.org/3/discover/movie?api_key=73321a7b17e84973837c579c8bb62fe7&language=en-US&sort_by=popularity.desc&include_adult=false&include_video=false&page=1&with_watch_monetization_types=flatrate&with_cast={actor.id}";
                var result = http.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                var obj = JsonConvert.DeserializeObject<Root>(json);
                return obj.results;
            }
        }
    }
}
