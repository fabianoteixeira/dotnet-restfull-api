using Demo.Business.Entities;
using Demo.Business.Interfaces;
using Demo.Data.Context;

namespace Demo.Data.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context): base(context)
        {

        }
    }
}
