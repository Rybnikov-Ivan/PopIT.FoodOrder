using Microsoft.EntityFrameworkCore;
using popIT.FoodOrder.Core.Orders;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace popIT.FoodOrder.Infrastructure.Data.Repositories
{
	public class OrderRepository : IOrderRepository
	{
		private readonly IGenericRepository<Order> _genericRepository;

		public OrderRepository(IGenericRepository<Order> genericRepository)
		{
			_genericRepository = genericRepository;
		}

		public async Task AddOrder(Order order)
		{
			await _genericRepository.Add(order);
		}

		public async Task<IEnumerable<Order>> GetAllCompletedOrdersForToday()
		{
			return await _genericRepository.GetAll(
				predicate: o => o.IsСompleted == true && o.OrderTime.Date == DateTime.Today,
				include: q => q.Include(o => o.Meat)
				   .Include(o => o.Soup)
				   .Include(o => o.Garnish)
				   .Include(o => o.Beverage));
		}

		public async Task<IEnumerable<Order>> GetAllUncompletedOrdersForToday()
		{
			return await _genericRepository.GetAll(
				predicate: o => o.IsСompleted == false && o.OrderTime.Date == DateTime.Today,
				include: q => q.Include(o => o.Meat)
				   .Include(o => o.Soup)
				   .Include(o => o.Garnish)
				   .Include(o => o.Beverage));
		}

		public async Task<Order> GetOrderById(int id)
		{
			return await _genericRepository.GetById(
				entityId: id, 
				include: q => q.Include(o => o.Meat)
				   .Include(o => o.Soup)
				   .Include(o => o.Garnish)
				   .Include(o => o.Beverage));
		}

		public async Task UpdateOrder(Order order)
		{
			await _genericRepository.Update(order);
		}
	}
}
