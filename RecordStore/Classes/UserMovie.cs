using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Models
{
    public partial class UserMovie
    {
        public UserMovie(MovieSearch.Result movie)
        {
            UserId = null;
            MovieTitle = movie.title;
            PurchasePrice = GetPrice(movie.release_date);
            MovieDesc = movie.overview;
            ReleaseDate = DateTime.Parse(movie.release_date);
            PurchaseDate = DateTime.Now;
            //need to fix imdbid
            ImdbId = movie.id.ToString();
            MoviesDbId = movie.id.ToString();
            //get first genre in id list
            //Genre= movie.gen


        }
        public int count { get; set; }
        public float GetPrice(string releasedate)
        {
           var price = 0F;   
            DateTime release = DateTime.Parse(releasedate); 
            var i = 0;  
            foreach(var decade in decades)
            {
                var nextdecade = decades.ElementAt(i+1);
                if (release>DateTime.Parse(decade.Key)&& release< DateTime.Parse(nextdecade.Key))
                {
                    price = decade.Value;
                }
                i++;
            }
            return price;
            
        }
        public Dictionary<string, float> decades = new Dictionary<string, float>()
        {
            { "1950-01-01",1.99F   },
            { "1960-01-01", 3.99F  },
            { "1970-01-01", 5.99F  },
            { "1980-01-01", 8.99F  },
            { "1990-01-01", 10.99F },
            { "2000-01-01", 12.99F },
            { "2010-01-01", 15.99F },
            { "2020-01-01", 18.99F },
            { "2021-01-01", 19.99F },
            { "2022-01-01", 24.99F }
        };
    }
}
