using System;
using System.Collections;
using System.Collections.Generic;
using LongLH9Shop.Data.Infrastructure;
using LongLH9Shop.Model.Models;
using System.Linq;

namespace LongLH9Shop.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}