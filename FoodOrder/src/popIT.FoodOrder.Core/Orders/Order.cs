using popIT.FoodOrder.Core.Beverages;
using popIT.FoodOrder.Core.Garnishes;
using popIT.FoodOrder.Core.General;
using popIT.FoodOrder.Core.Meats;
using popIT.FoodOrder.Core.Soups;
using popIT.FoodOrder.Core.Students;
using System;
using System.Collections.Generic;
using System.Text;

namespace popIT.FoodOrder.Core.Orders
{
	public class Order : BaseEntity
	{
		public DateTime OrderTime { get; set; }
		public bool IsСompleted { get; set; }

		public int BeverageId { get; set; }
		public Beverage Beverage { get; set; }

		public int GarnishId { get; set; }
		public Garnish Garnish { get; set; }

		public int MeatId { get; set; }
		public Meat Meat { get; set; }

		public int SoupId { get; set; }
		public Soup Soup { get; set; }

		public string StudentTicket { get; set; }
		public Student Student { get; set; }
	}
}
