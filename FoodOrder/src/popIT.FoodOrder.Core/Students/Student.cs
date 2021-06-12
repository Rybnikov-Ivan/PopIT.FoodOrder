using popIT.FoodOrder.Core.General;

namespace popIT.FoodOrder.Core.Students
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }

        public string StudentTicket { get; set; }
    }
}