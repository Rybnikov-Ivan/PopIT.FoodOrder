using AutoMapper;
using popIT.FoodOrder.Core.Garnishes.Requests;
using popIT.FoodOrder.Core.Garnishes.Responses;

namespace popIT.FoodOrder.Core.Garnishes.Mappings
{
    public class GarnishProfile : Profile
    {
        public GarnishProfile()
        {
            CreateMap<GarnishAddRequest, Garnish>();
            CreateMap<GarnishUpdateRequest, Garnish>();
            
            CreateMap<Garnish, GarnishResponse>();
        }
    }
}