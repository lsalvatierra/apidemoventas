using apidemoventas.Models;
using apidemoventas.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apidemoventas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _service.GetAllAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _service.GetByIdAsyncDto(id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Products product)
        {
            await _service.AddAsync(product);
            return CreatedAtAction(nameof(GetById), new { id = product.Productid }, product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Products product)
        {
            await _service.UpdateAsync(id, product);
            return NoContent();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> Patch(int id, [FromBody] Products partialProduct)
        {
            var existingProduct = await _service.GetByIdAsync(id);
            if (existingProduct == null) return NotFound();

            if (partialProduct.Productname != null)
                existingProduct.Productname = partialProduct.Productname;

            await _service.UpdateAsync(id, existingProduct);
            return NoContent();
        }
    }
}
