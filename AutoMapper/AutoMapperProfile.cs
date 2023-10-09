using AutoMapper;
using ProductsInventory.DTOS;
using ProductsInventory.Model;

namespace ProductsInventory.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, ProductDTOS>();
            CreateMap<Product, ProductGruopDTOS>();
            CreateMap<Product, ProductsReportDTOS>();
            CreateMap<Product, RecieptDTOS>();
            CreateMap<Product, TokenDTOS>();
            CreateMap<Product, VoucherDTOS>();
            CreateMap<ProductDTOS, Product>();
            CreateMap<ProductGruopDTOS, Product>();
            CreateMap<ProductsReportDTOS, Product>();
            CreateMap<RecieptDTOS, Product>();
            CreateMap<TokenDTOS, Product>();
            CreateMap<VoucherDTOS, Product>();

        }
    }
}
