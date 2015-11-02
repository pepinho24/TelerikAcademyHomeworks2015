namespace MusicSystem.Data.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<MusicSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(MusicSystemDbContext context)
        {
            SeedGenres(context);
            SeedCountries(context);
            SeedArtists(context);
            SeedAlbums(context);
            SeedSongs(context);
        }

        private void SeedAlbums(MusicSystemDbContext context)
        {
            for (int i = 0; i < 10; i++)
            {
                var album = new Album
                {
                    Title = "Seed Album " + i,
                    Producer = "Seed Producer " + i,
                    Year = 2000 + i
                };

                context.Albums.AddOrUpdate(c => c.Title, album);
            }

            context.SaveChanges();
        }

        private void SeedSongs(MusicSystemDbContext context)
        {
            var genreIds = context.Genres.Select(g => g.GenreId).ToList();
            var artistIds = context.Artists.Select(g => g.ArtistId).ToList();

            for (int i = 0; i < 10; i++)
            {
                var song = new Song
                {
                    Title = "Seed Song " + i,
                    ArtistId = artistIds[i % artistIds.Count],
                    GenreId = genreIds[i % genreIds.Count],
                    Year = 2000 + i
                };

                context.Songs.AddOrUpdate(c => c.Title, song);
            }

            context.SaveChanges();
        }

        private void SeedArtists(MusicSystemDbContext context)
        {
            var countryIds = context.Countries.Select(c => c.CountryId).ToList();

            for (int i = 0; i < 10; i++)
            {
                var artist = new Artist
                {
                    Name = "Seed Artist " + i,
                    DateOfBirth = DateTime.Now.AddDays(50 * i - 200),
                    CountryId = countryIds[i % countryIds.Count],
                };

                context.Artists.AddOrUpdate(c => c.Name, artist);
            }

            context.SaveChanges();
        }

        private void SeedCountries(MusicSystemDbContext context)
        {
            for (int i = 0; i < 5; i++)
            {
                var country = new Country
                {
                    Name = "Seed Country " + i
                };

                context.Countries.AddOrUpdate(c => c.Name, country);
            }

            context.SaveChanges();
        }

        private void SeedGenres(MusicSystemDbContext context)
        {
            for (int i = 0; i < 5; i++)
            {
                var genre = new Genre
                {
                    Name = "Seed Genre " + i
                };

                context.Genres.AddOrUpdate(g => g.Name, genre);
            }

            context.SaveChanges();
        }
    }
}
