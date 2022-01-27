// Author: Ryan Pinkney
// This is the category model

using System;
using System.ComponentModel.DataAnnotations;

namespace ismission5RyanPinkney.Models
{
    public class Category
    {
        // Primary key field for the table/model
        [Key]
        [Required]
        public int Category_id { get; set; }

        // Variable that will store the category full name
        public string sCategory_name { get; set; }







    }
}
