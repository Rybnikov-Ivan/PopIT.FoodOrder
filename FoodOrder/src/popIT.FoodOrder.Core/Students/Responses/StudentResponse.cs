using System.Collections.Generic;

namespace popIT.FoodOrder.Core.Students.Responses
{
    public class StudentResponse
    {
        public string StudentTicket { get; set; }
        public string Name { get; set; }
        public IEnumerable<int> Orders { get; set; }
    }
}