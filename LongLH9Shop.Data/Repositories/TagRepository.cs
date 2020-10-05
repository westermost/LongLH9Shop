using LongLH9Shop.Data.Infrastructure;
using LongLH9Shop.Model.Models;

namespace LongLH9Shop.Data.Repositories
{
    public interface ITagRepository : IRepository<Tag>
    {
    }

    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}