namespace LongLH9Shop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private LongLH9ShopDbContext dbContext;

        public LongLH9ShopDbContext Init()
        {
            return dbContext ?? (dbContext = new LongLH9ShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}