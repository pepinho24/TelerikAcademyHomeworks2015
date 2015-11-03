namespace MusicSystem.Services.Data.Contracts
{
    using System.Linq;
    using Models;

    public interface ISongsService
    {
        IQueryable<Song> All(int page = 1, int pageSize = 10);

        int Add(string title, int year, int artistId, int genreId);

        IQueryable<Song> ById(string SongName);

        void Update(int id, string title, int year, int artistId, int genreId);

        void Delete(int id);
    }
}
