using Microsoft.AspNetCore.Mvc;
using Tech_Potential_Challenge_Payment_API.Services.Interfaces;
using Tech_Potential_Challenge_Payment_API.ViewModels.Product;

namespace Tech_Potential_Challenge_Payment_API.Controllers
{
    [Route("products")]
    public class ProductController : BaseController
    {
        protected readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try            
            {
                var products = await _productService.GetAll();
                return Ok(products);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(new { message = "Error getting products." });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                var product = await _productService.GetById(id);

                if (product is null)
                    return NotFound();

                return Ok(product);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(new { message = $"Error getting product." });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateProductViewModel createProductViewModel)
        {
            try
            {
                var product = await _productService.Create(createProductViewModel);

                return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(new { message = $"Error adding product." });
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateProductViewModel updateProductViewModel)
        {
            try
            {
                var product = await _productService.Update(updateProductViewModel);

                if (product is null)
                    return NotFound();

                return Ok(product);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(new { message = $"Error changing product." });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var product = await _productService.Delete(id);

                if (product is null)
                    return NotFound();

                return Ok(product);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(new { message = $"Error deleting product." });            
            }
        }
    }
}