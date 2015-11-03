namespace MusicSystem.HttpConsoleClient.Models.Songs
{
    using MusicSystem.Models;
    public class SongDetailsResponseModel
    {
        public string Title { get; set; }
        
        public int Year { get; set; }
        
        public string GenreName { get; set; }
        
        public string ArtistName { get; set; }
    }
}