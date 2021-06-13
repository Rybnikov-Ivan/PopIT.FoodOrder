using System.Threading.Tasks;

namespace popIT.FoodOrder.Core.Students
{
    public interface IStudentRepository
    {
        Task<Student> GetStudentByTicket(string studentTicket);
    }
}