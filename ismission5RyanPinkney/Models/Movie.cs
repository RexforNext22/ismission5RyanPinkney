// Author: Ryan Pinkney
// This is the model for the movie. It has a foreign key relationship with the category model.


using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ismission5RyanPinkney.Models
{
    public class Movie
    {

        // Primary key for the database
        [Key]
        [Required]
        public int movie_id { get; set; }


        // Movie title
        [Required]
        public string sTitle { get; set; }

        // Movie year
        [Required]
        public string sYear { get; set; }

        // Movie director
        [Required]
        public string sDirector { get; set; }

        // Movie rating
        [Required]
        public string sRating { get; set; }

        // Movie edited
        public string sIsEdited { get; set; }

        // Movie lent to
        public string sLentToName { get; set; }

        // Movie notes
        public string sNotes { get; set; }


        // Foreign Key relationship

        // Movie category
        // Set as the foreign key
        [ForeignKey("Category")]
        public int Category_id { get; set; }


        // Category of type Category
        public Category Category { get; set; }





    }
}
