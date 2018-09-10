using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarvelMovies.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [RegularExpression(@"^[A-Z]+[\w\-]*$")]
        [StringLength(5)]
        public string Rated { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Released { get; set; }

        [Display(Name = "Run Time(Minutes)")]
        public int Runtime { get; set; }

        [RegularExpression(@"^[A-Z][^,]*(,\s*[A-Z][^,]*)*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }


        [StringLength(100)]
        public string Director { get; set; }


        public string Actors { get; set; }


        public string Plot { get; set; }

        [StringLength(30)]
        public string Poster { get; set; }

        [Display(Name = "IMDB Rating")]
        public decimal ImdbRating { get; set; }

        public int ImdbVotes { get; set; }

        [StringLength(30)]
        [Display(Name = "IMDB ID")]
        public string ImdbID { get; set; }
    }
}