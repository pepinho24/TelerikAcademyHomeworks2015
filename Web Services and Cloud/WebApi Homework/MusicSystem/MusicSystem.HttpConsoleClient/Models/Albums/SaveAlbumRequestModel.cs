namespace MusicSystem.HttpConsoleClient.Models.Albums
{
    public class SaveAlbumRequestModel
    {  
        public string Title { get; set; }
        
        public int Year { get; set; }

        public string Producer { get; set; }        
    }
}