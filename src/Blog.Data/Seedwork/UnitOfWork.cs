using AutoMapper;
using Blog.Core.Repository;
using Blog.Core.Seedwork;
using Blog.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Seedwork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogContext _context;
        public UnitOfWork(BlogContext context, IMapper mapper)
        {
            _context = context;
            Posts = new PostRepository(context, mapper);
        }

        public IPostRepository Posts { get; private set; }


        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
