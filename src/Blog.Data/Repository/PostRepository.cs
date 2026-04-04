using Blog.Core.Domain;
using Blog.Core.Repository;
using Blog.Data.Seedwork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Repository
{
    public class PostRepository : RepositoryBase<Post, Guid>, IPostRepository
    {
        
        public PostRepository(BlogContext context) : base(context)
        {
            
        }

        public Task<List<Post>> GetPopularPostsAsync(int count)
        {
            return _context.Posts.OrderByDescending(x => x.ViewCount).Take(count).ToListAsync();
        }
    }
}
