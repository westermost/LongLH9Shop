using LongLH9Shop.Data.Infrastructure;
using LongLH9Shop.Model.Models;

namespace LongLH9Shop.Data.Repositories
{
    public interface IPageRepository : IRepository<Page>
    {
    }

    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}