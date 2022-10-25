using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tech_Potential_Challenge_Payment_API.ViewModels.Seller;

namespace Tech_Potential_Challenge_Payment_API.Services.Interfaces
{
    public interface ISellerService
    {
        Task<SellerViewModel> GetById(Guid id);
        Task<IEnumerable<SellerViewModel>> GetAll();
        Task<SellerViewModel> Create(CreateSellerViewModel createSellerViewModel);
        Task<SellerViewModel> Update(UpdateSellerViewModel updateSellerViewModel);
        Task<SellerViewModel> Delete(Guid id);
    }
}