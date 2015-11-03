namespace MusicSystem.HttpConsoleClient
{
    using Models;
    using Models.Songs;
    using Models.Albums;
    using MusicSystem.Models;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using Models.Artists;

    public class Startup
    {
        public static void Main()
        {
            RunAsync().Wait();
            Console.Read();
        }

        static async Task RunAsync()
        {
            await GetAllSongs();
            await GetAllAlbums();
            await GetAllArtists();
        }

        private static async Task GetAllSongs()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:58640/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                HttpResponseMessage response = await client.GetAsync("api/songs");
                if (response.IsSuccessStatusCode)
                {
                    ICollection<SongDetailsResponseModel> songs = await response.Content.ReadAsAsync<ICollection<SongDetailsResponseModel>>();

                    foreach (var song in songs)
                    {
                        Console.WriteLine("{0} by \t{1}, Genre: \t{2}, year: {3}", song.Title, song.ArtistName, song.GenreName, song.Year);
                    }

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Failed");
                    Console.ReadKey();
                }
            }
        }

        private static async Task GetAllAlbums()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:58640/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                HttpResponseMessage response = await client.GetAsync("api/albums/all");
                if (response.IsSuccessStatusCode)
                {
                    ICollection<AlbumDetailsResponseModel> albums = await response.Content.ReadAsAsync<ICollection<AlbumDetailsResponseModel>>();

                    foreach (var album in albums)
                    {
                        Console.WriteLine("{0} by \t{1}, Artists: \t{2}, year: {3}, \t Songs: {4}", album.Title, album.Producer, string.Join(", ", album.Artists), album.Year, string.Join(", ", album.Songs));
                    }

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Failed");
                    Console.ReadKey();
                }
            }
        }

        private static async Task GetAllArtists()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:58640/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                HttpResponseMessage response = await client.GetAsync("api/artists/all");
                if (response.IsSuccessStatusCode)
                {
                    ICollection<ArtistDetailsResponseModel> artists = await response.Content.ReadAsAsync<ICollection<ArtistDetailsResponseModel>>();

                    foreach (var artist in artists)
                    {
                        Console.WriteLine("{0} born in {1}, {2}, Has {3} songs and {4} albums", artist.Name, artist.DateOfBirth.ToString(), artist.CountryName, artist.SongsCount, artist.AlbumsCount);
                    }

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Failed");
                    Console.ReadKey();
                }
            }
        }
    }
}
