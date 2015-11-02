namespace MusicSystem.Api.Models.Albums
{
    using Infrastructure.Mapping;
    using MusicSystem.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;
    using AutoMapper;

    public class AlbumDetailsResponseModel:IMapFrom<Album>, IHaveCustomMappings
    {
        //public AlbumDetailsResponseModel()
        //{
        //    this.Artists = new HashSet<string>();
        //    this.Songs = new HashSet<string>();
        //}

        public int AlbumId { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [Range(1000, 2070)]
        public int Year { get; set; }

        public string Producer { get; set; }

        public ICollection<string> Artists { get; set; }

        public ICollection<string> Songs { get; set; }

        public void CreateMappings(IConfiguration config)
        {
            config.CreateMap<Album, AlbumDetailsResponseModel>()
               .ForMember(a => a.Artists, opts => opts.MapFrom(a => a.Artists.Select(ar => ar.Name)))
               .ForMember(a => a.Songs, opts => opts.MapFrom(a => a.Songs.Select(s => s.Title)));
        }
    }
}