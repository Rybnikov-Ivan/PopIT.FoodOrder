using System.Threading.Tasks;
using AutoMapper;
using popIT.FoodOrder.Core.Exceptions;
using popIT.FoodOrder.Core.General;
using popIT.FoodOrder.Core.Students.Responses;

namespace popIT.FoodOrder.Core.Students
{
    public class StudentService : IStudentService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public StudentService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        
        public async Task<StudentResponse> GetStudentByTicket(string studentTicket)
        {
            var student = await _unitOfWork.GetRepository<IStudentRepository>().GetStudentByTicket(studentTicket);
            if (student == null)
            {
                throw new StudentAuthorizationException(studentTicket);
            }

            return _mapper.Map<StudentResponse>(student);
        }
    }
}