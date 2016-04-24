using DAL.Interfaces.Storage;
using Domain.Storage;

namespace DAL.Repositories.Storage
{
    public class ProductRepository : EFRepository<Product>, IProductRepository
    {
        public ProductRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}