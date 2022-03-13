using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.DecoratorPattern.Models;

namespace WebApp.DecoratorPattern.Repositories.Decorator
{
    public class ProductRepositoryCacheDecorator : BaseProductRepositoryDecorator
    {
        private readonly IMemoryCache _memoryCache;
        private const string ProductsCacheName = "products";
        public ProductRepositoryCacheDecorator(IProductRepository productRepository, IMemoryCache memoryCache) : base(productRepository)
        {
            _memoryCache = memoryCache;
        }
        public async override Task<List<Product>> GetAll()
        {
            // cachede data varsa true yoksa false döner
            if (_memoryCache.TryGetValue(ProductsCacheName, out List<Product> cacheProducts))
            {
                return cacheProducts;
            }
            await UpdateCache();
            return _memoryCache.Get<List<Product>>(ProductsCacheName);
        }
        public override async Task<List<Product>> GetAll(string userId)
        {
            var products = await GetAll();
            return products.Where(x => x.UserId == userId).ToList();
        }
        public override async Task<Product> Save(Product product)
        {
            await base.Save(product);
            await UpdateCache();
            return product;
        }
        public override async Task Update(Product product)
        {
            await base.Update(product);
            await UpdateCache();
        }
        public override async Task Remove(Product product)
        {
            await base.Remove(product);
            await UpdateCache();
        }

        private async Task UpdateCache()
        {
            _memoryCache.Set(ProductsCacheName, await base.GetAll());
        }
    }
}
