namespace MusicSystem.Api.Controllers
{
    using Data;
    using Models.Artists;
    using Data.Contracts;
    using MusicSystem.Models;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Http;

    public class ArtistsController : ApiController
    {
        private readonly IRepository<Artist> data;

        public ArtistsController()
        {
            var db = new MusicSystemDbContext();
            this.data = new EfGenericRepository<Artist>(db);
        }

        [Route("api/artists/all")]
        public IHttpActionResult Get(int page = 1, int pageSize = 10)
        {
            var artists = data
                .All()
                .Select(ArtistDetailsResponseModel.FromModel)
                .OrderBy(a=>a.ArtistId)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return this.Ok(artists);
        }

        public IHttpActionResult Get(int id)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);

            }

            var artist = data
                .All()
                .Select(ArtistDetailsResponseModel.FromModel)
                .FirstOrDefault(a=> a.ArtistId == id);

            if (artist == null)
            {
                return this.NotFound();
            }

            return this.Ok(artist);
        }

        public IHttpActionResult Post(SaveArtistRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }

            if (data.All().Any(a => a.Name == model.Name))
            {
                return this.BadRequest(string.Format("Artist with name '{0}' already exists!", model.Name));
            }

            var newArtist = new Artist()
            {
                CountryId = model.CountryId,
                DateOfBirth = model.DateOfBirth,
                Name = model.Name
            };

            data.Add(newArtist);
            data.SaveChanges();

            return this.Ok(newArtist.ArtistId);
        }

        [HttpPut]
        public IHttpActionResult Put(int id, SaveArtistRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }

            var dbArtist = data.GetById(id);

            if (dbArtist == null)
            {
                return this.NotFound();
            }

            dbArtist = new Artist()
            {
                ArtistId = id,
                CountryId = model.CountryId,
                DateOfBirth = model.DateOfBirth,
                Name = model.Name                
            };

            data.Add(dbArtist);
            data.SaveChanges();

            return this.Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            data.Delete(id);
            data.SaveChanges();

            return this.Ok();
        }
    }
}
