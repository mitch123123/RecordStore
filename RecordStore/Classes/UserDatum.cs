using homework9.Models;
using MovieStore.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieStore.Models
{
    public partial class UserDatum
    {
        [NotMapped]
        public Cart? usercart { get; set; }
        public static UserDatum LookupUserEF(string username, string password, out string error)
        {
            using (var context = new MovieDatabaseContext())
            {
                UserDatum curuser = null;
                error = "";
                if (context.UserData.Any(o => o.Username == username))
                {
                    curuser = context.UserData.Where(u => u.Username == username).Where(u => u.Password == password).FirstOrDefault();
                    curuser.usercart = new Cart();
                    if (curuser != null)
                    {
                        return curuser;
                    }
                }
                else
                {
                    error = "credentials not valid, try again";
                }
                return null;


            }
        }

        public static bool tryUpdateUserEF(UserDatum user, string pass, out string error)
        {
            error = "";
            using (var context = new MovieDatabaseContext())
            {
                var usertoupdate = context.UserData.SingleOrDefault(b => b.Username == user.Username);
                //need to make sure all user data is there
                usertoupdate = user;
                usertoupdate.Password = pass;
                //add error handling
                context.SaveChanges();
                return true;
            }



        }

        public static bool trycreateUserEF(UserDatum user, out string error)
        {

            string userinput;
            error = "";
            if (!user.checkusernameEF(user.Username))
            {
                error = $"username {user.Username} is already taken";
                return false;
            }
            else
            {
                using (var context = new MovieDatabaseContext())
                {
                    context.UserData.Add(user);
                    context.SaveChanges();
                    user.usercart = new Cart();
                }
                return true;
            }
        }
        public bool checkusernameEF(string username)
        {
            using (var context = new MovieDatabaseContext())
            {
                if (context.UserData.Any(o => o.Username == username))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public bool getage(string a, out string error)
        {
            error = "";
            if (!int.TryParse(a, out int age))
            {
                error = "invalid age";
                return false;
            }
            else
            {
                this.Age = age;
                return true;
            }

        }
        public void getLocation()
        {
            string fullLocation;
            using (var http = new HttpClient())
            {
                var endpoint = "http://www.ipinfo.io?token=e4cbd5a9f00587";
                var result = http.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                var obj = JsonConvert.DeserializeObject<IPInfo>(json);
                fullLocation = obj.city + "," + obj.region + "," + obj.country;
            }
            this.Location = fullLocation;
        }
        public void AddMovie(UserMovie movie)
        {
            using(var context = new MovieDatabaseContext())
            {
                AccountBalance -= movie.PurchasePrice + (movie.PurchasePrice * .06);
                context.UserMovies.Add(movie);
                context.SaveChanges();
            }
        }
        

        
    }
}
