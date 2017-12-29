using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class MovieContext:DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> contextOptions):base(contextOptions)
        {

        }
     public DbSet<Movie> Movie { get; set; }   


    }
}
