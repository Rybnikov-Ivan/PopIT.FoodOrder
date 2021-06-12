using AutoMapper;
using popIT.FoodOrder.Core.Soups.Response;

namespace popIT.FoodOrder.Core.Students.Mapping
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, SoupResponse>();
        }
    }
}