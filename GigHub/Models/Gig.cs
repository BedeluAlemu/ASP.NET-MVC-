﻿using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Gig
    {
        public int Id { get; set; }
        
        public virtual ApplicationUser Artist{ get; set; }
        [Required]
        public string ArtistId { get; set; }
 
        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(225)]
        public string  Venue{ get; set; }
        
        public Genre Genre { get; set; }
        [Required]
        public byte GenreId { get; set; }
                             
    }
}