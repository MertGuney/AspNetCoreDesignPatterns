using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.DecoratorPattern.Models;

namespace WebApp.DecoratorPattern.Repositories.Decorator
{
    public class ProductRepositoryLoggingDecorator : BaseProductRepositoryDecorator
    {
        private readonly ILogger<ProductRepositoryLoggingDecorator> _logger;
        public ProductRepositoryLoggingDecorator(IProductRepository productRepository, ILogger<ProductRepositoryLoggingDecorator> logger) : base(productRepository)
        {
            _logger = logger;
        }

        public override Task<List<Product>> GetAll()
        {
            _logger.LogInformation("GetAll methodu çalıştı.");
            return base.GetAll();
        }
        public override Task<List<Product>> GetAll(string userId)
        {
            _logger.LogInformation("GetAll(userId) methodu çalıştı.");
            return base.GetAll(userId);
        }
        public override Task<Product> Save(Product product)
        {

            _logger.LogInformation("Save methodu çalıştı.");
            return base.Save(product);
        }
        public override Task Update(Product product)
        {

            _logger.LogInformation("Update methodu çalıştı.");
            return base.Update(product);
        }
        public override Task Remove(Product product)
        {
            _logger.LogInformation("Remove methodu çalıştı.");
            return base.Remove(product);
        }
    }
}
