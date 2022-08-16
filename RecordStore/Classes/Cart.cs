using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Classes
{
    
    public class Cart
    {
        
        public BindingList<UserMovie> movies { get; set; }
        public float CartTotal { get; set; }
        public void GetTotal()
        {
            foreach(var movie in movies)
            {
                CartTotal += movie.PurchasePrice;
            }
        }
    }
}
