using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApiTest.Data;
using ApiTest.Models;
using ApiTest.Repositories;

namespace ApiTest.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly WebAssemblyAppServerDBContext _context;

        public ProductRepository(WebAssemblyAppServerDBContext context)
        {
            _context = context;
        }

        public async Task<Product> Create(Product Product)
        {
            _context.Products.Add(Product);
            await _context.SaveChangesAsync();

            return Product;
        }

        public async Task Delete(int id)
        {
            var ProductToDelete = await _context.Products.FindAsync(id);
            _context.Products.Remove(ProductToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> Get()
        {
            return await _context.Products.AsNoTracking().ToListAsync();
        }

        public async Task<Product> Get(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task Update(Product Product)
        {
            _context.Entry(Product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
