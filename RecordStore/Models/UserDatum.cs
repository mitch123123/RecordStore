using System;
using System.Collections.Generic;

namespace MovieStore.Models
{
    public partial class UserDatum
    {
        public Guid UserId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public int? Age { get; set; }
        public string? Location { get; set; }
        public double AccountBalance { get; set; }
      

    }
}
