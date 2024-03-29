﻿using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media.Imaging;

using MovieStore.Classes;

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
            public static string GetPopularity(int poprating)
            {
              if(poprating > 0&& poprating < 50)
                {
                    return "lame";
                }else if(poprating > 50 && poprating < 100)
                {
                    return "not bad";
                }else if(poprating > 100 && poprating < 500)
                {
                    return "pretty popular";
                }
                else
                {
                    return "SUPER POPULAR";
                }
            }
        }

        public class Root
        {
            public int page { get; set; }
            public List<Result> results { get; set; }
            public int total_pages { get; set; }
            public int total_results { get; set; }
        }

        private const string ApiKey = PrivateData.ApiKey;
        [NotMapped]
        public const string PopularEndpoint = $"https://api.themoviedb.org/3/discover/movie?api_key={ApiKey}&language=en-US&sort_by=popularity.desc";
        [NotMapped]
        public const string VoteEndpoint = $"https://api.themoviedb.org/3/discover/movie?api_key={ApiKey}&language=en-US&sort_by=vote_average.desc";
        [NotMapped]
        public const string ReleaseEndpoint = $"https://api.themoviedb.org/3/discover/movie?api_key={ApiKey}&language=en-US&sort_by=release_date.desc";
        [NotMapped]
        public const string RevenueEndpoint = $"https://api.themoviedb.org/3/discover/movie?api_key={ApiKey}&language=en-US&sort_by=revenue.desc";
        [NotMapped]
        public static string endpoint{ get; set; }

        public static List<Result> GetMoviesByName(string query)
        {
            using (var http = new HttpClient())
            {
                var Endpoint = $"https://api.themoviedb.org/3/search/movie?api_key={ApiKey}&query={query}";
                var result = http.GetAsync(Endpoint).Result;
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
                var Endpoint = $"https://api.themoviedb.org/3/discover/movie?api_key={ApiKey}&language=en-US&sort_by=popularity.desc&include_adult=false&include_video=false&page=1&with_watch_monetization_types=flatrate&with_cast={actor.id}";
                var result = http.GetAsync(Endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                var obj = JsonConvert.DeserializeObject<Root>(json);
                return obj.results;
            }
        }
        public static List<Result> GetSortedMovies(string type)
        {
            
            if (type == "popular")
            {
                endpoint = PopularEndpoint;
            }else if(type == "vote")
            {
                endpoint = VoteEndpoint;
            }else if(type == "release")
            {
                endpoint = ReleaseEndpoint;
            }else if(type == "revenue")
            {
                endpoint = RevenueEndpoint;
            }
            using (var http = new HttpClient())
            {
               
                var result = http.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                var obj = JsonConvert.DeserializeObject<Root>(json);
                return obj.results;
            }
        }
       
          
           
        
        public static string SetImageUrl(string image, string size)
        {
          
            if (size == "supersmall")
            {
                var url = $"https://image.tmdb.org/t/p/w92/{image}";
                return url;
            }
            else if (size == "small")
            {
                var url = $"https://image.tmdb.org/t/p/w154/{image}";
                return url;
            }
            else if (size == "medium")
            {
                var url = $"https://image.tmdb.org/t/p/w185/{image}";
                return url;
            }
            else if (size == "medium2")
            {
                var url = $"https://image.tmdb.org/t/p/w342/{image}";
                return url;
            }
            else if (size == "large")
            {
                var url = $"https://image.tmdb.org/t/p/w500/{image}";
                return url;
            }
            else
            {
                var url = $"https://image.tmdb.org/t/p/w780/{image}";
                return url;
            }
            

        }
       
    }
}
