using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Genre
    {
        public Int32 GenreID { get; set; }

        [Display(Name = "Genre Name")]
        public String GenreName { get; set; }

        public List<Movie> Movies { get; set; }

        public Genre()
        {
            if (Movies == null)
            {
                Movies = new List<Movies>();
            }
        }
    }
}
