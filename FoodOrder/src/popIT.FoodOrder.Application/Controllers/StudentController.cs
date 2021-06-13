using Microsoft.AspNetCore.Mvc;
using popIT.FoodOrder.Core.Students;
using popIT.FoodOrder.Core.Students.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace popIT.FoodOrder.Application.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class StudentController : ControllerBase
	{
		private readonly IStudentService _studentService;

		public StudentController(IStudentService studentService)
		{
			_studentService = studentService;
		}

		[HttpGet("{studentTicket}")]
		public async Task<ActionResult<Student>> GetStudentByTicket(string studentTicket)
		{
			var student = await _studentService.GetStudentByTicket(studentTicket);

			return Ok(student);
		}
	}
}
