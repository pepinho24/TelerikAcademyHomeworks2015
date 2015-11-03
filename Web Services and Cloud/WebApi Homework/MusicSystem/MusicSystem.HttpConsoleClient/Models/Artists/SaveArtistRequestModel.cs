namespace MusicSystem.HttpConsoleClient.Models.Artists
{
    using System;

    public class SaveArtistRequestModel
    {
        public string Name { get; set; }
        
        public int CountryId { get; set; }
        
        public DateTime DateOfBirth { get; set; }
    }
}