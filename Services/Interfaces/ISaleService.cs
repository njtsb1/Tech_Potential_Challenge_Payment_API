using Tech_Potential_Challenge_Payment_API.ViewModels.Sale;

namespace Tech_Potential_Challenge_Payment_API.Services.Interfaces
{
    public interface ISaleService
    {
        Task<SaleViewModel> GetById(Guid id);
        Task<IEnumerable<SaleViewModel>> GetAll();
        Task<SaleViewModel> Create(CreateSaleViewModel createSaleViewModel);
        Task<SaleViewModel> UpdateSaleStatus(UpdateSaleViewModel updateSaleViewModel);
    }
}