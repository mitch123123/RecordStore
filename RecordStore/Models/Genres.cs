using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Models
{
    public class Genres
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Genre
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class Root
        {
            public List<Genre> genres { get; set; }
        }
        public static List<Genre> GetGenres()
        {
            using (var http = new HttpClient())
            {
                var endpoint = "https://api.themoviedb.org/3/genre/movie/list?api_key=73321a7b17e84973837c579c8bb62fe7&language=en-US";
                var result = http.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                var obj = JsonConvert.DeserializeObject<Root>(json);
                return obj.genres;
            }
        }
        
    }
}
