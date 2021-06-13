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
			CreateMap<OrderAddRequest, Order>()
				.ForMember(o => o.OrderTime, opt => opt.MapFrom(src => DateTime.Now))
				.ForMember(o => o.IsСompleted, opt => opt.MapFrom(src => false));

			CreateMap<Order, OrderResponse>()
				.ForMember(r => r.TotalPrice, opt => opt.MapFrom(o => (o.Meat.Price + o.Soup.Price + o.Garnish.Price + o.Beverage.Price).ToString()));
		}
	}
}
