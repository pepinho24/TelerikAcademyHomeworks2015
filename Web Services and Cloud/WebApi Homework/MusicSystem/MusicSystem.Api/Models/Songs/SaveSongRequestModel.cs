namespace MusicSystem.Api.Models.Songs
{
    using System.ComponentModel.DataAnnotations;

    public class SaveSongRequestModel
    {
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [Range(1000, 2070)]
        public int Year { get; set; }

        [Required]
        public int GenreId { get; set; }
        
        [Required]
        public int ArtistId { get; set; }
    }
}