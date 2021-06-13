using AutoMapper;
using popIT.FoodOrder.Core.Exceptions;
using popIT.FoodOrder.Core.General;
using popIT.FoodOrder.Core.Orders.Requests;
using popIT.FoodOrder.Core.Orders.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace popIT.FoodOrder.Core.Orders
{
	public class OrderService : IOrderService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public OrderService(IUnitOfWork unitOfWork, IMapper autoMapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = autoMapper;
		}

		public async Task<OrderResponse> AddOrder(OrderAddRequest orderAddRequest)
		{
			var order = _mapper.Map<Order>(orderAddRequest);
			await _unitOfWork.GetRepository<IOrderRepository>().AddOrder(order);

			await _unitOfWork.SaveChangesAsync();
			return _mapper.Map<OrderResponse>(order);
		}

		public async Task<IEnumerable<OrderResponse>> GetAllCompletedOrdersForToday()
		{
			var orders = await _unitOfWork.GetRepository<IOrderRepository>().GetAllCompletedOrdersForToday();

			return _mapper.Map<IEnumerable<OrderResponse>>(orders);
		}

		public async Task<IEnumerable<OrderResponse>> GetAllUncompletedOrdersForToday()
		{
			var orders = await _unitOfWork.GetRepository<IOrderRepository>().GetAllUncompletedOrdersForToday();

			return _mapper.Map<IEnumerable<OrderResponse>>(orders);
		}

		public async Task<OrderResponse> GetOrderById(int id)
		{
			var order = await _unitOfWork.GetRepository<IOrderRepository>().GetOrderById(id);
			if(order == null)
			{
				throw new EntityIdNotFoundException(nameof(Order), id);
			}

			return _mapper.Map<OrderResponse>(order);
		}

		public async Task OrderIsCompleted(int id)
		{
			var order = await _unitOfWork.GetRepository<IOrderRepository>().GetOrderById(id);
			if(order == null)
			{
				throw new EntityIdNotFoundException(nameof(Order), id);
			}

			order.IsСompleted = true;

			await _unitOfWork.GetRepository<IOrderRepository>().UpdateOrder(order);
			await _unitOfWork.SaveChangesAsync();
		}
	}
}
