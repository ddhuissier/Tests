using ApiTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest.Core
{
    public interface IProductService
    {
        public Task<IEnumerable<Product>> GetProducts();
        public Task<Product> GetProduct(int id);
    }
}
