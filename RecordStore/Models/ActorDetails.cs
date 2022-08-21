using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Models
{
    internal class ActorDetails
    {
        public class Root
        {
            public bool adult { get; set; }
            public List<string> also_known_as { get; set; }
            public string biography { get; set; }
            public string birthday { get; set; }
            public string? deathday { get; set; }
            public int gender { get; set; }
            public string homepage { get; set; }
            public int id { get; set; }
            public string imdb_id { get; set; }
            public string known_for_department { get; set; }
            public string name { get; set; }
            public string place_of_birth { get; set; }
            public double popularity { get; set; }
            public string profile_path { get; set; }
        }

        public static Root GetActorDetails(int actorId)
        {
            using (var http = new HttpClient())
            {
                var endpoint = $"https://api.themoviedb.org/3/person/{actorId}?api_key=73321a7b17e84973837c579c8bb62fe7&language=en-US";
                var result = http.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                var obj = JsonConvert.DeserializeObject<Root>(json);
                return obj;

            }
        }
        public static string getage(string date)
        {
            DateTime dob = Convert.ToDateTime(date);
            DateTime Now = DateTime.Now;
            int Years = new DateTime(DateTime.Now.Subtract(dob).Ticks).Year - 1;
           

            return $"Age: {Years} Years";
            
        }
        public static string getGender(int gen)
        {
            if (gen == 2)
            {
                return "male";

            }
            else
            {
                return "female";
            }
        }
        public static string Alive(string deathdate)
        {
            if(deathdate == null)
            {
                return "Yes";
            }
            else
            {
                return "no";
            }
        }
    }
}
