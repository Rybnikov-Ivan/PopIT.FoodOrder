using AutoMapper;
using popIT.FoodOrder.Core.Beverages;
using popIT.FoodOrder.Core.Exceptions;
using popIT.FoodOrder.Core.Garnishes;
using popIT.FoodOrder.Core.General;
using popIT.FoodOrder.Core.Meats;
using popIT.FoodOrder.Core.Orders.Requests;
using popIT.FoodOrder.Core.Orders.Responses;
using popIT.FoodOrder.Core.Soups;
using popIT.FoodOrder.Core.Students;
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
			if(await _unitOfWork.GetRepository<IStudentRepository>().GetStudentByTicket(orderAddRequest.StudentTicket) == null)
			{
				throw new StudentAuthorizationException(orderAddRequest.StudentTicket);
			}
			
			if(await _unitOfWork.GetRepository<ISoupRepository>().GetSoupById(orderAddRequest.SoupId) == null)
			{
				throw new EntityIdNotFoundException(nameof(Soup), orderAddRequest.SoupId);
			}
			
			if(await _unitOfWork.GetRepository<IMeatRepository>().GetMeatById(orderAddRequest.MeatId) == null)
			{
				throw new EntityIdNotFoundException(nameof(Meat), orderAddRequest.MeatId);
			}
			
			if(await _unitOfWork.GetRepository<IGarnishRepository>().GetGarnishById(orderAddRequest.GarnishId) == null)
			{
				throw new EntityIdNotFoundException(nameof(Garnish), orderAddRequest.GarnishId);
			}
			
			if(await _unitOfWork.GetRepository<IBeverageRepository>().GetBeverageById(orderAddRequest.BeverageId) == null)
			{
				throw new EntityIdNotFoundException(nameof(Beverage), orderAddRequest.BeverageId);
			}

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
