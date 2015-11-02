namespace MusicSystem.Data
{
    using Contracts;
    using MusicSystem.Models;
    using System.Data.Entity;

    public class MusicSystemDbContext : DbContext, IMusicSystemDbContext
    {
        public MusicSystemDbContext()
            : base("MusicSystem")
        {
        }

        public virtual IDbSet<Artist> Artists { get; set; }

        public virtual IDbSet<Album> Albums { get; set; }

        public virtual IDbSet<Song> Songs { get; set; }

        public virtual IDbSet<Country> Countries { get; set; }

        public virtual IDbSet<Genre> Genres { get; set; }

        public static MusicSystemDbContext Create()
        {
            return new MusicSystemDbContext();
        }
    }
}
