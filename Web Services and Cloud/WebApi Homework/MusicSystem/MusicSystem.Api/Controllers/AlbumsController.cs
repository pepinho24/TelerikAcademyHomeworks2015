﻿namespace MusicSystem.Api.Controllers
{

    using Data;
    using Models.Artists;
    using Data.Contracts;
    using MusicSystem.Models;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Http;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Models.Albums;

    public class AlbumsController : ApiController
    {
        private readonly IRepository<Album> data;

        public AlbumsController()
        {
            var db = new MusicSystemDbContext();
            this.data = new EfGenericRepository<Album>(db);
        }

        [Route("api/albums/all")]
        public IHttpActionResult Get(int page = 1, int pageSize = 10)
        {
            var albums = data
                .All()
                .OrderBy(a=>a.AlbumId)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return this.Ok(albums);
        }
        
        public IHttpActionResult Get(int id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }
            // Old code, before the implementation of IMapFrom and IHaveCustomMappings
            //Mapper.CreateMap<Album, AlbumDetailsResponseModel>()
            //    .ForMember(a => a.Artists, opts => opts.MapFrom(a => a.Artists.Select(ar => ar.Name)))
            //    .ForMember(a => a.Songs, opts => opts.MapFrom(a => a.Songs.Select(s => s.Title)));

            var album = data
                .All()
                .ProjectTo<AlbumDetailsResponseModel>()
                .FirstOrDefault(a => a.AlbumId == id);

            if (album == null)
            {
                return this.NotFound();
            }

            return this.Ok(album);
        }

        public IHttpActionResult Post(SaveAlbumRequestModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }

            if (model == null)
            {
                return this.BadRequest("Album cannot be null!");
            }
            
            if (data.All().Any(a => a.Title == model.Title))
            {
                return this.BadRequest(string.Format("Album with Title '{0}' already exists!", model.Title));
            }

            var dbAlbum = Mapper.Map<Album>(model);

            data.Add(dbAlbum);
            data.SaveChanges();

            return this.Ok(dbAlbum.AlbumId);
        }

        [HttpPut]
        public IHttpActionResult Put(int id, SaveAlbumRequestModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }

            if (model == null)
            {
                return this.BadRequest("Album cannot be null!");
            }

            var dbModel = data.GetById(id);
            if (dbModel == null)
            {
                return this.NotFound();
            }
            
            var dbAlbum = Mapper.Map<Album>(model);
            dbAlbum.AlbumId = id;

            data.Update(dbAlbum);
            data.SaveChanges();

            return this.Ok(dbAlbum.AlbumId);
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
