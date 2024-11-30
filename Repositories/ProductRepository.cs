using apidemoventas.Models;
using Microsoft.EntityFrameworkCore;

namespace apidemoventas.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly BdventasContext _context;

        public ProductRepository(BdventasContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Products>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Products> GetByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task AddAsync(Products product)
        {
            await _context.Products.AddAsync(product);
        }

        public async Task UpdateAsync(Products product)
        {
            _context.Products.Update(product);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
