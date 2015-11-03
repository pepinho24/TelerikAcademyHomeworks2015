namespace MusicSystem.Services.Data
{
    using System.Linq;
    using Models;
    using MusicSystem.Services.Data.Contracts;
    using MusicSystem.Data.Contracts;
    using System;

    public class SongsService : ISongsService
    {
        private readonly IRepository<Song> songs;

        public SongsService(IRepository<Song> songsRepo)
        {
            this.songs = songsRepo;
        }

        public int Add(string title, int year, int artistId, int genreId)
        {
            var newSong = new Song
            {
                Title = title,
                Year = year,
                ArtistId = artistId,
                GenreId = genreId
            };
            
            this.songs.Add(newSong);
            this.songs.SaveChanges();

            return newSong.SongId;
        }

        public IQueryable<Song> ById(string songName)
        {
            return this.songs
                .All()
                .Where(s=>s.Title == songName);
        }

        public IQueryable<Song> All(int page = 1, int pageSize = 10)
        {
            return this.songs
                .All()
                .OrderByDescending(s => s.Year)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);
        }

        public void Update(int id, string title, int year, int artistId, int genreId)
        {
            var dbSong = new Song()
            {
                SongId = id,
                ArtistId = artistId,
                GenreId = genreId,
                Title = title, 
                Year = year
            };

           this.songs.Update(dbSong);
        }

        public void Delete(int id)
        {
            this.songs.Delete(id);
        }
    }
}
