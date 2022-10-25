using Microsoft.AspNetCore.Mvc;
using Tech_Potential_Challenge_Payment_API.Services.Interfaces;
using Tech_Potential_Challenge_Payment_API.ViewModels.Seller;

namespace Tech_Potential_Challenge_Payment_API.Controllers
{
    [Route("sellers")]
    public class SellerController : BaseController
    {
        protected readonly ILogger<SellerController> _logger;
        private readonly ISellerService _sellerService;

        public SellerController(ILogger<SellerController> logger, ISellerService sellerService)
        {
            _logger = logger;
            _sellerService = sellerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try            
            {
                var sellers = await _sellerService.GetAll();
                return Ok(sellers);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(new { message = "Error getting sellers." });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                var seller = await _sellerService.GetById(id);

                if (seller is null)
                    return NotFound();

                return Ok(seller);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(new { message = $"Error getting seller." });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateSellerViewModel createSellerViewModel)
        {
            try
            {
                var seller = await _sellerService.Create(createSellerViewModel);

                return CreatedAtAction(nameof(GetById), new { id = seller.Id }, seller);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(new { message = $"Error adding seller." });
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateSellerViewModel updateSellerViewModel)
        {
            try
            {
                var seller = await _sellerService.Update(updateSellerViewModel);

                if (seller is null)
                    return NotFound();

                return Ok(seller);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(new { message = $"Error changing seller." });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var seller = await _sellerService.Delete(id);

                if (seller is null)
                    return NotFound();

                return Ok(seller);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(new { message = $"Error deleting seller." });            
            }
        }    
    }
}