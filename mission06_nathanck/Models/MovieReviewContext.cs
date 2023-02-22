using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission06_nathanck.Models
{
  
    public class MovieReviewContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieCategory>().HasData(
            new MovieCategory { Id = 1, CategoryName = "Action/Adventure" },
            new MovieCategory { Id = 2, CategoryName = "Comedy" },
            new MovieCategory { Id = 3, CategoryName = "Drama" },
            new MovieCategory { Id = 4, CategoryName = "Family" },
            new MovieCategory { Id = 5, CategoryName = "Horror/suspense" },
            new MovieCategory { Id = 6, CategoryName = "Misc" },
            new MovieCategory { Id = 7, CategoryName = "Drama" },
            new MovieCategory { Id = 8, CategoryName = "TV" },
            new MovieCategory { Id = 9, CategoryName = "VHS" }











            );
        }
        public MovieReviewContext (DbContextOptions<MovieReviewContext> options) : base(options)
        {
            //leave blank for now
        }
        public DbSet<ApplicationResponse> responses { get; set; }
        public DbSet<MovieCategory> Movies { get; set; }
    }
}
