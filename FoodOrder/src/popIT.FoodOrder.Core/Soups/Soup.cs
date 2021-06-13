using popIT.FoodOrder.Core.General;
using popIT.FoodOrder.Core.Orders;
using System.Collections.Generic;

namespace popIT.FoodOrder.Core.Soups
{
    public class Soup : BaseEntity
    {
        public string Name { get; set; }
		public int Price { get; set; }

		public IEnumerable<Order> Orders { get; set; }
	}
}