using Microsoft.AspNetCore.Mvc;
using popIT.FoodOrder.Core.Orders;
using popIT.FoodOrder.Core.Orders.Requests;
using popIT.FoodOrder.Core.Orders.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace popIT.FoodOrder.Application.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class OrderController : ControllerBase
	{
		private readonly IOrderService _orderService;

		public OrderController(IOrderService orderService)
		{
			_orderService = orderService;
		}

		[HttpGet("{id}", Name = "GetOrderById")]
		public async Task<ActionResult<IEnumerable<OrderResponse>>> GetOrderById(int id)
		{
			var response = await _orderService.GetOrderById(id);

			return Ok(response);
		}

		[HttpGet("completed")]
		public async Task<ActionResult<IEnumerable<OrderResponse>>> GetAllCompletedOrdersForToday()
		{
			var response = await _orderService.GetAllCompletedOrdersForToday();

			return Ok(response);
		}

		[HttpGet("uncompleted")]
		public async Task<ActionResult<IEnumerable<OrderResponse>>> GetAllUncompletedOrdersForToday()
		{
			var response = await _orderService.GetAllUncompletedOrdersForToday();

			return Ok(response);
		}

		/// <summary>
		/// Вызывается, когда заказ выполнен
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[HttpPut("{id}/completed")]
		public async Task<IActionResult> OrderIsCompleted(int id)
		{
			await _orderService.OrderIsCompleted(id);

			return NoContent();
		}

		[HttpPost]
		public async Task<ActionResult<OrderResponse>> AddOrder(OrderAddRequest orderAddRequest)
		{
			var response = await _orderService.AddOrder(orderAddRequest);

			return CreatedAtRoute(nameof(GetOrderById), new { response.Id }, response);
		}
	}
}
