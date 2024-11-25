using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EliteMart.Data;
using EliteMart.Model;
using EliteMart.Helpers;
using EliteMart.Interfaces;
using EliteMart.Mappers;
using EliteMart.DTOS.Product;

namespace EliteMart.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IProductRepository _productRepo;

        public ProductsController(AppDbContext context, IProductRepository productRepo)
        {
            _productRepo = productRepo;
            _context = context;
        }

        //to return all the list of record in the database
        // GET: api/Products
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] ProductQueryObject productquery)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var products = await _productRepo.GetAllAsync(productquery);

            var ProductDto = products.Select(s => s.ToProductDto());
            return Ok(products);
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var productModel = await _productRepo.GetByIdAsync(id); ;

            if (productModel == null)
            {
                return NotFound();
            }

            return Ok(productModel.ToProductDto());
        }

        // POST: api/Products CREATE
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateProductDto productDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var productModel = productDto.ToProductFromProductDto();
            await _productRepo.CreateAsync(productModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProduct), new { id = productModel.Id }, productModel.ToProductDto());
        }


        // PUT: api/Products/5 EDIT
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateProductDto updatedDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var productModel = await _productRepo.UpdateAsync(id, updatedDto);

            if (productModel == null)
            {
                return NotFound();
            }

            return Ok(productModel.ToProductDto());
        }


        // DELETE: api/Customers/5   DELETE
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var productModel = await _productRepo.DeleteAsync(id);
            if (productModel == null)
            {
                return NotFound();
            }



            return NoContent();
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}