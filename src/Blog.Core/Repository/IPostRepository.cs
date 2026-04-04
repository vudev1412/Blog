using Blog.Core.Domain;
using Blog.Core.Model;
using Blog.Core.Model.Content;
using Blog.Core.Seedwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Repository
{
    public interface IPostRepository : IRepository<Post, Guid>
    {
        Task<List<Post>> GetPopularPostsAsync(int count);

        Task<PagedResult<PostInListDTO>> GetPostsPagingAsync(string keyword, Guid? categoryId, int pageIndex = 1, int pageSize = 10);

    }
}
