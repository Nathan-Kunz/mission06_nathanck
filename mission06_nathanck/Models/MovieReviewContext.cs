using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission06_nathanck.Models
{
    public class MovieReviewContext : DbContext
    {
        public MovieReviewContext (DbContextOptions<MovieReviewContext> options) : base(options)
        {
            //leave blank for now
        }
        public DbSet<ApplicationResponse> responses { get; set; }

    }
}
