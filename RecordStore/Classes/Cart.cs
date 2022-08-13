using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Classes
{
    public class Cart
    {
        
        public List<UserMovie> movies { get; set; }
        public float CartTotal { get; set; }

    }
}
