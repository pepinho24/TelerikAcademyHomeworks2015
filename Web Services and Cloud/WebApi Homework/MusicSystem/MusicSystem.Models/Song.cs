namespace MusicSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Song
    {
        public int SongId { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [Range(1000,2070)]
        public int Year { get; set; }

        [Required]
        public int GenreId { get; set; }

        public virtual Genre Genre { get; set; }

        [Required]
        public int ArtistId { get; set; }

        public virtual Artist Artist { get; set; }
    }
}
