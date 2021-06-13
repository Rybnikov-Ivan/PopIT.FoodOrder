using popIT.FoodOrder.Core.General;
using popIT.FoodOrder.Core.Orders;
using System.Collections.Generic;

namespace popIT.FoodOrder.Core.Meats
{
    public class Meat : BaseEntity
    {
        public string Name { get; set; }

		public IEnumerable<Order> Orders { get; set; }
	}
}