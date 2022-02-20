using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.StrategyPattern.Models;

namespace WebApp.StrategyPattern.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(string id);
        Task<List<Product>> GetAllByUserId(string userId);
        Task<Product> Save(Product product);
        Task Update(Product product);
        Task Delete(Product product);
    }
}
