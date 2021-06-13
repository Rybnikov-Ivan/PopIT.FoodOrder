using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using popIT.FoodOrder.Core.Students;

namespace popIT.FoodOrder.Infrastructure.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DbSet<Student> _dbSet;
		public StudentRepository(FoodOrderDbContext context)
		{
			_dbSet = context.Set<Student>();
		}

		public Task<Student> GetStudentByTicket(string studentTicket)
		{
			return _dbSet.Include(s => s.Orders)
				.FirstOrDefaultAsync(s => s.StudentTicket == studentTicket);
		}
	}
}