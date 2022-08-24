using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Models
{
    public class Promocodes
    {
        public int PromoId { get; set; }    
        public string PromoName { get; set; }
        public string PromoDesc { get; set; }
        public double PromoValue { get; set; }
        public int promoRequirement { get; set; }
    }
}
