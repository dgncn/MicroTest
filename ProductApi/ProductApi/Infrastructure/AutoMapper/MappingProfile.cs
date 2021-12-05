using AutoMapper;
using ProductApi.Domain.Entities;
using ProductApi.Models.v1;

namespace ProductApi.Infrastructure.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateProductModel, Product>().ForMember(x => x.Id, option => option.Ignore());
        }
    }
}
