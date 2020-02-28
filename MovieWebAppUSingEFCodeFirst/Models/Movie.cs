using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieWebAppUSingEFCodeFirst.Models
{
    public class Movie
    {
        [Required]
        [Key]
        public int Movie_id { get; set; }
        [Required]
        [Display(Name = "Movie Name")]
        public string Movie_Name { get; set; }
        [Required]
        [Display(Name = "Reelease date")]
        [DataType(DataType.DateTime)]
        public DateTime Release_Date { get; set; }
    }
}