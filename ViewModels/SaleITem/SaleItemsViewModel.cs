using Tech_Potential_Challenge_Payment_API.ViewModels.Product;

namespace Tech_Potential_Challenge_Payment_API.ViewModels.SaleITem
{
    public class SaleItemsViewModel
    {
        public Guid Id { get; set; }
        public Guid SaleId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }

        public ProductViewModel Produtct { get; set; }
    }
}