using System;

namespace LongLH9Shop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        LongLH9ShopDbContext Init();
    }
}