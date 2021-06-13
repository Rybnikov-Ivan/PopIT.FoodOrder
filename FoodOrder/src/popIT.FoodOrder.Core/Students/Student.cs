using popIT.FoodOrder.Core.General;
using popIT.FoodOrder.Core.Orders;
using System.Collections.Generic;

namespace popIT.FoodOrder.Core.Students
{
    public class Student
    {
        public string StudentTicket { get; set; }
        public string Name { get; set; }

		public IEnumerable<Order> Orders { get; set; }
	}
}