using AutoMapper;
using Blog.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Model.Content
{
    public class PostInListDTO
    {

        public Guid Id { get; set; }

        public required string Name { get; set; }

        public required string Slug { get; set; }


        public string? Decription { get; set; }

        public Guid CategoryId { get; set; }

        public string? Thumbnail { get; set; }


        public int ViewCount { get; set; }

        public DateTime DateCreated { get; set; }

        public class AutoMapperProfiles : Profile
        {
            public AutoMapperProfiles()
            {
                CreateMap<Post, PostInListDTO>();
            }
        }

    }
}
