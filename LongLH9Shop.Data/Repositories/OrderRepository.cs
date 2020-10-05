using LongLH9Shop.Data.Infrastructure;
using LongLH9Shop.Model.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LongLH9Shop.Data.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}