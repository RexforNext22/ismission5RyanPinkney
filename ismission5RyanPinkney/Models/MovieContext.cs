// Author: Ryan Pinkney
// This is the Movie Context class


using System;
using Microsoft.EntityFrameworkCore;

namespace ismission5RyanPinkney.Models
{
    public class MovieContext : DbContext
    {
        // Constructor
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
       
        }

        public DbSet<Movie> responses { get; set; }

        // Second line for the next table
        public DbSet<Category> categories { get; set; }



        protected override void OnModelCreating(ModelBuilder mb)
        {

            // Seed the values for the Category table when we build the database
            mb.Entity<Category>().HasData(

                new Category
                {
                    Category_id = 1,
                    sCategory_name = "Action/Adventure"

                },

                new Category
                {
                    Category_id = 2,
                    sCategory_name = "Comedy"

                },

                new Category
                {
                    Category_id = 3,
                    sCategory_name = "Drama"

                },

                 new Category
                 {
                     Category_id = 4,
                     sCategory_name = "Family"

                 },

                 new Category
                 {
                     Category_id = 5,
                     sCategory_name = "Horror/Suspense"

                 },
                 new Category
                 {
                     Category_id = 6,
                     sCategory_name = "Miscellaneous"

                 },
                 new Category
                 {
                     Category_id = 7,
                     sCategory_name = "Television"

                 },
                 new Category
                 {
                     Category_id = 8,
                     sCategory_name = "VHS"

                 }) ;




            // Seed the values for the Movie table when we build the database
            mb.Entity<Movie>().HasData(

                new Movie
                {
                    movie_id = 1,
                    sTitle = "Avenger, The",
                    sYear = "2012",
                    sDirector = "Joss Whedon",
                    Category_id = 1,
                    sRating = "PG-13",
                    sIsEdited = "false",
                    sLentToName = "",
                    sNotes = ""
                },
                new Movie
                {
                    movie_id = 2,
                    sTitle = "Batman",
                    sYear = "1989",
                    sDirector = "Tim Burton",
                    Category_id = 1,
                    sRating = "PG-13",
                    sIsEdited = "false",
                    sLentToName = "",
                    sNotes = ""

                },
                new Movie
                {
                    movie_id = 3,
                    sTitle = "Batman & Robin",
                    sYear = "1997",
                    sDirector = "Joel Schumacher",
                    Category_id = 1,
                    sRating = "PG-13",
                    sIsEdited = "false",
                    sLentToName = "",
                    sNotes = ""

                }

                );
        }

    }
}
