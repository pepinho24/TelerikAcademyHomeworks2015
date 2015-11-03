namespace MusicSystem.HttpConsoleClient.Models.Songs
{
    public class SaveSongRequestModel
    {
        public string Title { get; set; }
        
        public int Year { get; set; }
        
        public int GenreId { get; set; }
        
        public int ArtistId { get; set; }
    }
}