using Tech_Potential_Challenge_Payment_API.ViewModels.SaleITem;

namespace Tech_Potential_Challenge_Payment_API.ViewModels.Sale
{
    public class CreateSaleViewModel
    {        
        public Guid SellerId { get; set; }
        public DateTime Date { get; set; }

        public IEnumerable<CreateSaleItemsViewModel> Items { get; set; }
    }
}