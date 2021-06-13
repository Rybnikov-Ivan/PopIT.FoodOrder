using AutoMapper;
using popIT.FoodOrder.Core.Students.Responses;
using System.Linq;

namespace popIT.FoodOrder.Core.Students.Mapping
{
	public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, StudentResponse>()
                .ForMember(r => r.Orders, opt => opt.MapFrom(s => s.Orders.Select(o => o.Id)));
        }
    }
}