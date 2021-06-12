using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using popIT.FoodOrder.Core.Beverages;
using popIT.FoodOrder.Core.Beverages.Requests;
using popIT.FoodOrder.Core.Beverages.Responses;

namespace popIT.FoodOrder.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BeverageController : ControllerBase
    {
        private readonly IBeverageService _beverageService;

        public BeverageController(IBeverageService beverageService)
        {
            _beverageService = beverageService;
        }
        
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BeverageResponse>>> GetAllBeverages()
        {
            var response = await _beverageService.GetAllBeverages();

            return Ok(response);
        }
        
        [HttpGet("{id}", Name = "GetBeverageById")]
        public async Task<ActionResult<BeverageResponse>> GetBeverageById(int id)
        {
            var response = await _beverageService.GetBeverageById(id);

            return Ok(response);
        }
        
        [HttpPost]
        public async Task<ActionResult<BeverageResponse>> AddBeverage(BeverageAddRequest beverageAddRequest)
        {
            var response = await _beverageService.AddBeverage(beverageAddRequest);

            return CreatedAtRoute(nameof(GetBeverageById), new {Id = response.Id}, response);
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBeverage(int id, BeverageUpdateRequest beverageUpdateRequest)
        {
            await _beverageService.UpdateBeverage(id, beverageUpdateRequest);
            
            return NoContent();
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBeverage(int id)
        {
            await _beverageService.DeleteBeverage(id);
            
            return NoContent();
        }
    }
}