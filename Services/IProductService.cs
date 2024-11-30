using apidemoventas.Dto;
using apidemoventas.Models;

namespace apidemoventas.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllAsync();
        Task<Products> GetByIdAsync(int id);
        Task<ProductDto> GetByIdAsyncDto(int id);
        Task AddAsync(Products product);
        Task UpdateAsync(int id, Products product);
    }
}
