namespace MusicSystem.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using AutoMapper.QueryableExtensions;
    using Models.Songs;
    using Services.Data.Contracts;

    public class SongsController : ApiController
    {
        private readonly ISongsService songs;

        public SongsController(ISongsService songsService)
        {
            this.songs = songsService;
        }
        
        [HttpGet]
        public IHttpActionResult Get()
        {
            var result = this.songs
                .All()
                .ProjectTo<SongDetailsResponseModel>()
                .ToList();

            return this.Ok(result);
        }
        
        public IHttpActionResult Get(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return this.BadRequest("Song name cannot be null or empty.");
            }

            var result = this.songs
                .ById(id)
                .ProjectTo<SongDetailsResponseModel>()
                .FirstOrDefault();

            if (result == null)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }
        
        public IHttpActionResult Post(SaveSongRequestModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var createdSongId = this.songs.Add(
                model.Title,
                model.Year,
                model.ArtistId,
                model.GenreId);

            return this.Ok(createdSongId);
        }

        [Route("api/songs/all")]
        public IHttpActionResult Get(int page, int pageSize = 10)
        {
            var result = this.songs
                .All(page, pageSize)
                .ProjectTo<SongDetailsResponseModel>()
                .ToList();

            return this.Ok(result);
        }

        public IHttpActionResult Put(int id,SaveSongRequestModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            this.songs.Update(id,
                model.Title,
                model.Year,
                model.ArtistId,
                model.GenreId);

            return this.Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            this.songs.Delete(id);

            return this.Ok();
        }
    }
}
