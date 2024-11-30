using apidemoventas.Models;
using AutoMapper;

namespace apidemoventas.Dto
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Products, ProductDto>().ReverseMap();
        }
    }
}
