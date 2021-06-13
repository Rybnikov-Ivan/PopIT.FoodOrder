using System.Threading.Tasks;
using popIT.FoodOrder.Core.Students.Responses;

namespace popIT.FoodOrder.Core.Students
{
    public interface IStudentService
    {
        Task<StudentResponse> GetStudentByTicket(string studentTicket);
	}
}