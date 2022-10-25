using Tech_Potential_Challenge_Payment_API.Utils;

namespace Tech_Potential_Challenge_Payment_API.ViewModels.Sale
{
    public class UpdateSaleViewModel
    {
        public Guid Id { get; set; }
        public SaleStatusEnum Status { get; set; }
    }
}