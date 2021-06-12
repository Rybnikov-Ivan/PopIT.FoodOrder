using AutoMapper;
using popIT.FoodOrder.Core.Beverages.Requests;
using popIT.FoodOrder.Core.Beverages.Responses;

namespace popIT.FoodOrder.Core.Beverages.Mappings
{
    public class BeverageProfile : Profile
    {
        public BeverageProfile()
        {
            CreateMap<BeverageAddRequest, Beverage>();
            CreateMap<BeverageUpdateRequest, Beverage>();

            CreateMap<Beverage, BeverageResponse>();
        }
    }
}