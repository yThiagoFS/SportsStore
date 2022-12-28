using SportsStore.Context;
using SportsStore.Repository;

namespace SportsStore.Models
{
    public class StoreRepository : IStoreRepository
    {
        private readonly StoreContext _context;

        public StoreRepository(StoreContext context)
        {
            _context = context;
        }
        public IQueryable<Product> Products => _context.Products;
    }
}
