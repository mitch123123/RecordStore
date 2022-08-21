using System;
using System.Collections.Generic;

namespace MovieStore.Models
{
    public partial class UserMovie
    {
        public Guid? UserId { get; set; }
        public string MovieTitle { get; set; } = null!;
        public double PurchasePrice { get; set; }
        public string MovieDesc { get; set; } = null!;
        public DateTime ReleaseDate { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string ImdbId { get; set; } = null!;
        public string MoviesDbId { get; set; } = null!;
        public string? Genre { get; set; }
        public string? imageUrl { get; set; }
    }
}
