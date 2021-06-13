using System;
using System.Collections.Generic;
using System.Text;

namespace popIT.FoodOrder.Core.Orders.Requests
{
	public class OrderAddRequest
	{
		public int BeverageId { get; set; }
		public int GarnishId { get; set; }
		public int MeatId { get; set; }
		public int SoupId { get; set; }
		public string StudentTicket { get; set; }
	}
}
