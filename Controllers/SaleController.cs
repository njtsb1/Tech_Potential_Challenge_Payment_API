using Microsoft.AspNetCore.Mvc;
using Tech_Potential_Challenge_Payment_API.Services.Interfaces;
using Tech_Potential_Challenge_Payment_API.ViewModels.Sale;

namespace Tech_Potential_Challenge_Payment_API.Controllers
{
    [Route("sales")]
    public class SaleController : BaseController
    {
        protected readonly ILogger<SaleController> _logger;
        private readonly ISaleService _saleService;

        public SaleController(ILogger<SaleController> logger, ISaleService saleService)
        {
            _logger = logger;
            _saleService = saleService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try            
            {
                var sales = await _saleService.GetAll();
                return Ok(sales);
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
                var sale = await _saleService.GetById(id);

                if (sale is null)
                    return NotFound();

                return Ok(sale);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(new { message = $"Error getting product." });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateSaleViewModel createSaleViewModel)
        {
            try
            {
                var sale = await _saleService.Create(createSaleViewModel);

                return CreatedAtAction(nameof(GetById), new { id = sale.Id }, sale);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(new { message = $"Error adding product." });
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateSaleViewModel updateSaleViewModel)
        {
            try
            {
                var sale = await _saleService.UpdateSaleStatus(updateSaleViewModel);

                if (sale is null)
                    return NotFound();

                if (sale.Status != updateSaleViewModel.Status)
                    return BadRequest("Error updating sale status.");

                return Ok(sale);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(new { message = $"Error changing product." });
            }
        }
    }
}