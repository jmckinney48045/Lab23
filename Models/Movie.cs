using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Lab23.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public MovieGenre Genre { get; set; }

        public Movie(string title, MovieGenre genre)
        {
            Title = title;
            Genre = genre;
        }
        public class MovieDBContext : DbContext
        {
            public DbSet<Movie> Movies { get; set; }
        }
    }
}
}

    

