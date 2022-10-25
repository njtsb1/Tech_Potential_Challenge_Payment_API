using Tech_Potential_Challenge_Payment_API.Contexts;
using Tech_Potential_Challenge_Payment_API.Models;
using Tech_Potential_Challenge_Payment_API.Repositories.Interfaces;

namespace Tech_Potential_Challenge_Payment_API.Repositories
{
    public class SellerRepository : BaseRepository<Seller>, ISellerRepository
    {
        public SellerRepository(DataContext context) : base(context)
        {
        }
    }
}