using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using popIT.FoodOrder.Core.Meats;
using popIT.FoodOrder.Core.Meats.Requests;
using popIT.FoodOrder.Core.Meats.Response;

namespace popIT.FoodOrder.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MeatController : ControllerBase
    {
        private readonly IMeatService _meatService;

        public MeatController(IMeatService meatService)
        {
            _meatService = meatService;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MeatResponse>>> GetAllMeats()
        {
            var response = await _meatService.GetAllMeats();

            return Ok(response);
        }
        
        [HttpGet("{id}", Name = "GetMeatById")]
        public async Task<ActionResult<MeatResponse>> GetMeatById(int id)
        {
            var response = await _meatService.GetMeatById(id);

            return Ok(response);
        }
        
        [HttpPost]
        public async Task<ActionResult<MeatResponse>> AddMeat(MeatAddRequest meatAddRequest)
        {
            var response = await _meatService.AddMeat(meatAddRequest);

            return CreatedAtRoute(nameof(GetMeatById), new {Id = response.Id}, response);
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMeat(int id, MeatUpdateRequest meatUpdateRequest)
        {
            await _meatService.UpdateMeat(id, meatUpdateRequest);
            
            return NoContent();
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMeat(int id)
        {
            await _meatService.DeleteMeat(id);
            
            return NoContent();
        }
    }
}