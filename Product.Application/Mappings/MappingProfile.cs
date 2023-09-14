using AutoMapper;
using Product.Application.Models;
using Product.Domain;

namespace Product.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductDTO, Producto>();
            CreateMap<ProductUpdate, Producto>();
        }
    }
}
