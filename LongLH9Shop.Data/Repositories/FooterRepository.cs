using LongLH9Shop.Data.Infrastructure;
using LongLH9Shop.Model.Models;

namespace LongLH9Shop.Data.Repositories
{
    public interface IFooterRepository : IRepository<Footer>
    {
    }

    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}