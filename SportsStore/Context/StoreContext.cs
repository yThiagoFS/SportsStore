using Microsoft.EntityFrameworkCore;
using SportsStore.Models;

namespace SportsStore.Context
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }
        public DbSet<Product> Products => Set<Product>();
    }
}
