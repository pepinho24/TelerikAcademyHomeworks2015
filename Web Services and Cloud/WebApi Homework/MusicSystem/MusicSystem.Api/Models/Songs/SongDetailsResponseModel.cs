namespace MusicSystem.Api.Models.Songs
{
    using Infrastructure.Mapping;
    using MusicSystem.Models;
    using System.ComponentModel.DataAnnotations;

    public class SongDetailsResponseModel: IMapFrom<Song>
    {
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [Range(1000, 2070)]
        public int Year { get; set; }

        [Required]
        public string GenreName { get; set; }

        [Required]
        public string ArtistName { get; set; }
    }
}