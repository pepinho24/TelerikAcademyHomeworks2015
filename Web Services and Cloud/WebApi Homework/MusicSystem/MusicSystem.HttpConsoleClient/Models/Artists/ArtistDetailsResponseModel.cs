namespace MusicSystem.HttpConsoleClient.Models.Artists
{
    using System;

    public class ArtistDetailsResponseModel
    {
        public int ArtistId { get; set; }
        
        public string Name { get; set; }
        
        public string CountryName { get; set; }
        
        public DateTime DateOfBirth { get; set; }

        public int SongsCount { get; set; }

        public int AlbumsCount { get; set; }
    }
}