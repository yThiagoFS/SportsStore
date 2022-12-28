using SportsStore.Models;

namespace SportsStore.Repository
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
