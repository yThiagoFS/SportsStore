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

        public void CreateProduct(Product p)
        {
            _context.Add(p);
            _context.SaveChanges();
        }
        public void DeleteProduct(Product p)
        {
            _context.Remove(p);
            _context.SaveChanges();
        }
        public void SaveProduct(Product p)
        {
            _context.SaveChanges();
        }
    }
}
