using ApiTest.Data;
using ApiTest.Models;
using ApiTest.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest.Core
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;
        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public async Task<Product> GetProduct(int id)
        {
            return await _repo.Get(id);
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _repo.Get();
        }
    }
}
