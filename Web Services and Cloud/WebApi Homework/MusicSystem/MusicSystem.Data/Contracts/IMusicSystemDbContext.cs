namespace MusicSystem.Data.Contracts
{
    using System.Data.Entity;
    using MusicSystem.Models;
    using System.Data.Entity.Infrastructure;

    public interface IMusicSystemDbContext
    {
        IDbSet<Album> Albums { get; set; }

        IDbSet<Artist> Artists { get; set; }

        IDbSet<Country> Countries { get; set; }

        IDbSet<Genre> Genres { get; set; }

        IDbSet<Song> Songs { get; set; }
        
        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        void Dispose();

        int SaveChanges();
    }
}