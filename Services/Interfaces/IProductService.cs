using Tech_Potential_Challenge_Payment_API.ViewModels.Product;

namespace Tech_Potential_Challenge_Payment_API.Services.Interfaces
{
    public interface IProductService
    {
        Task<ProductViewModel> GetById(Guid id);
        Task<IEnumerable<ProductViewModel>> GetAll();
        Task<ProductViewModel> Create(CreateProductViewModel createProductViewModel);
        Task<ProductViewModel> Update(UpdateProductViewModel updateProductViewModel);
        Task<ProductViewModel> Delete(Guid id);
    }
}