using Tech_Potential_Challenge_Payment_API.Utils;
using Tech_Potential_Challenge_Payment_API.ViewModels.SaleITem;
using Tech_Potential_Challenge_Payment_API.ViewModels.Seller;

namespace Tech_Potential_Challenge_Payment_API.ViewModels.Sale
{
    public class SaleViewModel
    {
        public Guid Id { get; set; }
        public Guid SellerId { get; set; }
        public DateTime Date { get; set; }        
        public SaleStatusEnum Status { get; set; }

        public SellerViewModel Seller { get; set; }
        public List<SaleItemsViewModel> Items { get; set; }

        public SaleViewModel()
        {
            Items = new List<SaleItemsViewModel>();
        }
    }
}