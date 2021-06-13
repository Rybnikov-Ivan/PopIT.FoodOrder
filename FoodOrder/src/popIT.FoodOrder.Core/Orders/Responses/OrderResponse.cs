using popIT.FoodOrder.Core.Beverages.Responses;
using popIT.FoodOrder.Core.Garnishes.Responses;
using popIT.FoodOrder.Core.Meats.Response;
using popIT.FoodOrder.Core.Soups.Response;
using System;

namespace popIT.FoodOrder.Core.Orders.Responses
{
	public class OrderResponse
	{
		public int Id { get; set; }
		public string StudentTicket { get; set; }
		public DateTime OrderTime { get; set; }
		public string TotalPrice { get; set; }
		public BeverageResponse Beverage { get; set; }
		public GarnishResponse Garnish { get; set; }
		public MeatResponse Meat { get; set; }
		public SoupResponse Soup { get; set; }
	}
}
