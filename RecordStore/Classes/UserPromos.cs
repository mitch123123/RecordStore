using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStore.Models;
namespace MovieStore.Classes
{
    public class UserPromos
    {
        public int promoid { get; set; }
        public Guid userId { get; set; }
        public string Promoname { get; set; }
        public double PromoValue { get; set; }
        public UserPromos(int pId, Guid userid, string pname, double pvalue)
        {
            promoid = pId;
            userId = userid;
            Promoname = pname;
            PromoValue = pvalue;
        }
        public UserPromos()
        {
          
        }
        public static List<UserPromos> GetUserPromos(UserDatum user)
        {
            using (var context = new MovieDatabaseContext())
            {
                var promoList = context.UserPromos.Where(a => a.userId == user.UserId).ToList();
                return promoList;
            }
        }
        public static void CheckForPromosAvailable(UserDatum user,string condition,out UserPromos newpromo )
        {
            using (var context = new MovieDatabaseContext())
            {
                var p = new UserPromos();
                p = null;
                foreach (var promo in context.Promocodes)
                {
                    if (user.usercart.CartTotal > promo.promoRequirement)
                    {
                        p = new UserPromos(promo.PromoId, user.UserId, promo.PromoName, promo.PromoValue);

                    }
                }
                
              
                if (condition != null)
                {
                    if(condition == "newuser")
                    {
                        var newp = context.Promocodes.Where(a=>a.PromoId == 1).First();
                         p = new UserPromos(newp.PromoId, user.UserId, newp.PromoName, newp.PromoValue);
                        UserPromos.GivePromo( p,out newpromo);
                        newpromo = p;
                    }
                    else
                    {
                        newpromo=null;
                    }

                }
                else if(p!=null)
                {
                    UserPromos.GivePromo(p, out newpromo);
                    newpromo= p;
                }
                else
                {
                    newpromo = null;
                }
                
             
            }
        }
        public static void GivePromo(UserPromos promo,out UserPromos newpromo)
        {
            //check if promo exists first, then give promo to user
            using(var context = new MovieDatabaseContext())
            {
                if (!context.UserPromos.Contains(promo))
                {
                    context.UserPromos.Add(promo);
                    context.SaveChanges();
                    newpromo = promo;
                }
                else
                {
                    newpromo = null;
                }
            }
        }
        public static void RemovePromo(UserDatum user, UserPromos promo)
        {
            using (var context = new MovieDatabaseContext())
            {
               var promoToDelete= context.UserPromos.Where(a => a.userId == user.UserId).Where(a=> a.promoid == promo.promoid).FirstOrDefault();
                if(promoToDelete != null)
                {
                    context.UserPromos.Remove(promoToDelete);
                    context.SaveChanges();
                }
               
            }
        }
    }
}
