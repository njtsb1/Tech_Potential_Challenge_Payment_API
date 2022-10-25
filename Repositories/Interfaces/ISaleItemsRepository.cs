using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tech_Potential_Challenge_Payment_API.Models;

namespace Tech_Potential_Challenge_Payment_API.Repositories.Interfaces
{
    public interface ISaleItemsRepository : IBaseRepository<SaleItems>
    {
         Task<IEnumerable<SaleItems>> GetAllBySaleId(Guid saleId);
    }
}