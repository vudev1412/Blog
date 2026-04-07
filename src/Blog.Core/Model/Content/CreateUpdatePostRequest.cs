using AutoMapper;
using Blog.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Model.Content
{
    public class CreateUpdatePostRequest
    {
        public required string Name { get; set; }

        public required string Slug { get; set; }


        public string? Decription { get; set; }
        public string? Thumbnail { get; set; }
        public Guid CategoryId { get; set; }
         
        public string? Content { get; set; }

        public string? Source { get; set; }
        public string? Tags { get; set; }

        public string? SeoDecription { get; set; }



        public class AutoMapperProfiles : Profile
        {
            public AutoMapperProfiles()
            {
                CreateMap<CreateUpdatePostRequest, Post>();
            }
        }




    }
}
