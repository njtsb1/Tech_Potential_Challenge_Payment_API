using AutoMapper;
using Tech_Potential_Challenge_Payment_API.Models;
using Tech_Potential_Challenge_Payment_API.ViewModels.Product;
using Tech_Potential_Challenge_Payment_API.ViewModels.Sale;
using Tech_Potential_Challenge_Payment_API.ViewModels.SaleITem;
using Tech_Potential_Challenge_Payment_API.ViewModels.Seller;

namespace Tech_Potential_Challenge_Payment_API.Services.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Product, ProductViewModel>().ReverseMap();
            CreateMap<CreateProductViewModel, Product>();
            CreateMap<UpdateProductViewModel, Product>();

            CreateMap<Seller, SellerViewModel>().ReverseMap();
            CreateMap<CreateSellerViewModel, Seller>();
            CreateMap<UpdateSellerViewModel, Seller>();

            CreateMap<Sale, SaleViewModel>().ReverseMap();
            CreateMap<CreateSaleViewModel, Sale>();
            CreateMap<UpdateSaleViewModel, Sale>();

            CreateMap<SaleItems, SaleItemsViewModel>().ReverseMap();
            CreateMap<CreateSaleItemsViewModel, SaleItems>();            
        }
    }
}