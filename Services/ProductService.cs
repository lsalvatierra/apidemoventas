using apidemoventas.Dto;
using apidemoventas.Models;
using apidemoventas.Repositories;
using AutoMapper;

namespace apidemoventas.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            var products = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }

        public async Task<Products> GetByIdAsync(int id)
        {            
            return await _repository.GetByIdAsync(id);
        }
        public async Task<ProductDto> GetByIdAsyncDto(int id)
        {
            var product = await _repository.GetByIdAsync(id);
            return _mapper.Map<ProductDto>(product);
        }

        public async Task AddAsync(Products product)
        {
            await _repository.AddAsync(product);
            await _repository.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, Products product)
        {
            var existingProduct = await _repository.GetByIdAsync(id);
            if (existingProduct == null) throw new KeyNotFoundException("Product not found");

            existingProduct.Productname = product.Productname;
            existingProduct.Unitprice = product.Unitprice;
            existingProduct.Discontinued = product.Discontinued;

            await _repository.UpdateAsync(existingProduct);
            await _repository.SaveChangesAsync();
        }
    }
}
