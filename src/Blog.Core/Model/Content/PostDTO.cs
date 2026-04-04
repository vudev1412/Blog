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
    public class PostDTO : PostInListDTO
    {


        public string? Content { get; set; }

        public Guid AuthorUserId { get; set; }
        public string? Source { get; set; }
        public string? Tags { get; set; }

        public string? SeoDecription { get; set; }



        public DateTime? DateModified { get; set; }

        public bool IsPaid { get; set; }

        public double? RoyaltyAmout { get; set; }

        public PostStatus status { get; set; }

        public class AutoMapperProfiles : Profile
        {
            public AutoMapperProfiles()
            {
                CreateMap<Post, PostDTO>();
            }
        }
    }
}
