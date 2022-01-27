using System;
using Microsoft.EntityFrameworkCore;

namespace ismission5RyanPinkney.Models
{
    public class MovieContext : DbContext
    {
        // Constructor
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            // Leave blank for now
        }

        public DbSet<Movie> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Movie>().HasData(

                new Movie
                {
                    movie_id = 1,
                    sTitle = "Avenger, The",
                    sYear = "2012",
                    sDirector = "Joss Whedon",
                    sCategory = "Action/Adventure",
                    sRating = "PG-13",
                    bIsEdited = false,
                    sLentToName = "",
                    sNotes = ""
                },
                new Movie
                {
                    movie_id = 2,
                    sTitle = "Batman",
                    sYear = "1989",
                    sDirector = "Tim Burton",
                    sCategory = "Action/Adventure",
                    sRating = "PG-13",
                    bIsEdited = false,
                    sLentToName = "",
                    sNotes = ""

                },
                new Movie
                {
                    movie_id = 3,
                    sTitle = "Batman & Robin",
                    sYear = "1997",
                    sDirector = "Joel Schumacher",
                    sCategory = "Action/Adventure",
                    sRating = "PG-13",
                    bIsEdited = false,
                    sLentToName = "",
                    sNotes = ""

                }

                );
        }

    }
}
