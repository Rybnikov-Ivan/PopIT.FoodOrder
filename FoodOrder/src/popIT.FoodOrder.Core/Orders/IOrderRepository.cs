using System.Collections.Generic;
using System.Threading.Tasks;

namespace popIT.FoodOrder.Core.Orders
{
	public interface IOrderRepository
	{
		Task<Order> GetOrderById(int id);

		Task<IEnumerable<Order>> GetAllCompletedOrdersForToday();
		
		Task<IEnumerable<Order>> GetAllUncompletedOrdersForToday();

		Task AddOrder(Order order);

		Task UpdateOrder(Order order);
	}
}
