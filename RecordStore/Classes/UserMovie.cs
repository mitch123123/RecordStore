using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Models
{
    public partial class UserMovie
    {
        [NotMapped]
        public List<Genres.Genre> AllGenres { get; set; }
        [NotMapped]
        public List<int> genre_ids { get; set; }
       
        
        public UserMovie()
        {

        }
       
        public UserMovie(MovieSearch.Result movie)
        {
            if(movie.release_date == null)
            {
                ReleaseDate=DateTime.Now;
            }
            else if (movie.release_date == "")
            {
                ReleaseDate = DateTime.Now;
            }
            else
            {
                ReleaseDate = DateTime.Parse(movie.release_date);
            }
            genre_ids = movie.genre_ids;
            string genreslist="Genres: ";
            AllGenres = Genres.GetGenres();         
            foreach (var genre in genre_ids){
                var s = AllGenres.Find(x => x.id == genre);
                genreslist += s.name+",";
            }
            UserId = null;
            imageUrl = movie.poster_path;
            MovieTitle = movie.title;
            PurchasePrice = GetPrice(ReleaseDate.ToString());
            MovieDesc = movie.overview;
            PurchaseDate = DateTime.Now;
            //need to fix imdbid
            ImdbId = movie.id.ToString();
            MoviesDbId = movie.id.ToString();           
            Genre = genreslist; 
        }
       
        public float GetPrice(string releasedate)
        {
            DateTime release;
            var price = 0F;   
            if (releasedate != null)
            {
                 release = DateTime.Parse(releasedate);
            }
            else
            {
                return 0;
            }
            
            var i = 0;  
            var max = decades.Count;
            foreach(var decade in decades)
            {
                if (max > i+1)
                { 
                    var nextdecade = decades.ElementAt(i + 1);
                    if (release > DateTime.Parse(decade.Key) && release < DateTime.Parse(nextdecade.Key))
                    {
                        price = decade.Value;
                        break;
                    }
                    i++;
                }
                else
                {
                    price = decade.Value;
                }
               
                
            }
            return price;
            
        }
        [NotMapped]
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
