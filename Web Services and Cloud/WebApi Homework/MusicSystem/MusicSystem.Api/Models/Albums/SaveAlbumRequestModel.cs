namespace MusicSystem.Api.Models.Albums
{
    using System.ComponentModel.DataAnnotations;

    public class SaveAlbumRequestModel
    {          
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [Range(1000, 2070)]
        public int Year { get; set; }

        public string Producer { get; set; }        
    }
}