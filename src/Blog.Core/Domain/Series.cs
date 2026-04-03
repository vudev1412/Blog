using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Domain
{
    [Table("Series")]
    [Index(nameof(Slug), IsUnique = true)]
    public class Series
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public required string Name { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string? Description { get; set; }

        [MaxLength(250)]
        public required string Slug { get; set; }

        public bool IsActive { get; set; }

        public int SortOrder { get; set; }


        [MaxLength(250)]
        public string? SeoDecription { get; set; }

        [MaxLength(250)]
        public string? Thumbnail { get; set; }

        public string? Content { get; set; }

        public Guid AuthorUserId { get; set; }
        
        public DateTime DateCreated { get; set; }


    }
}
