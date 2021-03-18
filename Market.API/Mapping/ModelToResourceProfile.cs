using AutoMapper;
using Market.API.Domain.Models;
using Market.API.Domain.Models.Queries;
using Market.API.Extensions;
using Market.API.Resources;

namespace Market.API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();

            CreateMap<Product, ProductResource>()
                .ForMember(src => src.UnitOfMeasurement,
                    opt => opt.MapFrom(src => src.UnitOfMeasurement.ToDescriptionString()));

            CreateMap<QueryResult<Product>, QueryResultResource<ProductResource>>();
        }
    }
}