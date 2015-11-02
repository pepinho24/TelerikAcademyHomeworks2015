namespace MusicSystem.Api.Models.Artists
{
    using MusicSystem.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq.Expressions;

    public class ArtistDetailsResponseModel
    {
        public static Expression<Func<Artist, ArtistDetailsResponseModel>> FromModel
        {
            get
            {
                return a => new ArtistDetailsResponseModel
                {
                    ArtistId = a.ArtistId,
                    AlbumsCount = a.Albums.Count,
                    CountryName = a.Country.Name,
                    DateOfBirth = a.DateOfBirth,
                    Name = a.Name,
                    SongsCount = a.Songs.Count
                };
            }
        }

        public int ArtistId { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public string CountryName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public int SongsCount { get; set; }

        public int AlbumsCount { get; set; }
    }
}