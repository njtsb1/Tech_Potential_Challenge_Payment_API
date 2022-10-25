using Microsoft.EntityFrameworkCore;
using Tech_Potential_Challenge_Payment_API.Contexts;
using Tech_Potential_Challenge_Payment_API.Models;
using Tech_Potential_Challenge_Payment_API.Repositories.Interfaces;

namespace Tech_Potential_Challenge_Payment_API.Repositories
{
    public class SaleItemsRepository : BaseRepository<SaleItems>, ISaleItemsRepository
    {
        public SaleItemsRepository(DataContext context) : base(context)
        {
            
        }

        public async Task<IEnumerable<SaleItems>> GetAllBySaleId(Guid saleId)
        {
            return await _context.SalesItems.Where(w => w.SaleId == saleId).ToListAsync();
        }
    }
}