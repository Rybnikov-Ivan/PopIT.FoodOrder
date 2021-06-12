using AutoMapper;
using popIT.FoodOrder.Core.Soups.Requests;
using popIT.FoodOrder.Core.Soups.Response;

namespace popIT.FoodOrder.Core.Soups.Mappings
{
    public class SoupProfile : Profile
    {
        public SoupProfile()
        {
            CreateMap<SoupAddRequest, Soup>();
            CreateMap<SoupUpdateRequest, Soup>();

            CreateMap<Soup, SoupResponse>();
        }
    }
}