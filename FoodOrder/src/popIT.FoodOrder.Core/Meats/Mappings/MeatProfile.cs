using AutoMapper;
using popIT.FoodOrder.Core.Meats.Requests;
using popIT.FoodOrder.Core.Meats.Response;

namespace popIT.FoodOrder.Core.Meats.Mappings
{
    public class MeatProfile : Profile
    {
        public MeatProfile()
        {
            CreateMap<MeatAddRequest, Meat>();
            CreateMap<MeatUpdateRequest, Meat>();

            CreateMap<Meat, MeatResponse>();
        }
    }
}