using System.Threading.Tasks;
using popIT.FoodOrder.Core.Students;

namespace popIT.FoodOrder.Infrastructure.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IGenericRepository<Student> _genericRepository;

        public StudentRepository(IGenericRepository<Student> genericRepository)
        {
            _genericRepository = genericRepository;
        }
        
        public async Task<Student> GetStudentById(int id)
        {
            return await _genericRepository.GetById(id);
        }
    }
}