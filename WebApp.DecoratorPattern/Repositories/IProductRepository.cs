﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.DecoratorPattern.Models;

namespace WebApp.DecoratorPattern.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetById(int id);
        Task<List<Product>> GetAll();
        Task<List<Product>> GetAll(string userId);
        Task<Product> Save(Product product);
        Task Update(Product product);
        Task Remove(Product product);
    }
}
