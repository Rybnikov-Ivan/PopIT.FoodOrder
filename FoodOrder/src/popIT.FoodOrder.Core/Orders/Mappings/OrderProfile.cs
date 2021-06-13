using AutoMapper;
using popIT.FoodOrder.Core.Orders.Requests;
using popIT.FoodOrder.Core.Orders.Responses;
using System;

namespace popIT.FoodOrder.Core.Orders.Mappings
{
	public class OrderProfile : Profile
	{
		public OrderProfile()
		{
			// MapFrom or UseValue? https://docs.automapper.org/en/stable/8.0-Upgrade-Guide.html#id3
			CreateMap<OrderAddRequest, Order>()
				.ForMember(o => o.OrderTime, opt => opt.MapFrom(src => DateTime.Now))
				.ForMember(o => o.IsСompleted, opt => opt.MapFrom(src => false));

			CreateMap<Order, OrderResponse>();
		}
	}
}
