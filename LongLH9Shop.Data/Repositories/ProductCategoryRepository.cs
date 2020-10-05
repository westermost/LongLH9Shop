using LongLH9Shop.Data.Infrastructure;
using LongLH9Shop.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace LongLH9Shop.Data.Repositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory>
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }

    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return (IEnumerable<ProductCategory>)this.DbContext.PostCategories.Where(x => x.Alias == alias);
        }
    }
}