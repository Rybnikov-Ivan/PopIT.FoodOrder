using popIT.FoodOrder.Core.Orders.Requests;
using popIT.FoodOrder.Core.Orders.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace popIT.FoodOrder.Core.Orders
{
	public interface IOrderService
	{
		Task<OrderResponse> AddOrder(OrderAddRequest orderAddRequest);
		Task<IEnumerable<OrderResponse>> GetAllCompletedOrdersForToday();
		Task<IEnumerable<OrderResponse>> GetAllUncompletedOrdersForToday();
		Task<OrderResponse> GetOrderById(int id);
		Task OrderIsCompleted(int id);
	}
}
