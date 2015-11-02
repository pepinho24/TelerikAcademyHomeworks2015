using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicSystem.Api.Models.Artists
{
    public class SaveArtistRequestModel
    {
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public int CountryId { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}