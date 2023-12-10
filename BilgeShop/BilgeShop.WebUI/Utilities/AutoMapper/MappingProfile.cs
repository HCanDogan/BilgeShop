using AutoMapper;
using BilgeShop.Business.Dtos;
using BilgeShop.Data.Entities;
using BilgeShop.WebUI.Areas.Admin.Models;
using BilgeShop.WebUI.Models;


namespace BilgeShop.WebUI.Utilities.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductEntity, EditProductDto>();
            CreateMap<EditProductDto, ProductEntity>().ForMember(x => x.Id, options=>options.Ignore());
            CreateMap<EditProductDto, ProductFormViewModel>();
        }
    }
}
