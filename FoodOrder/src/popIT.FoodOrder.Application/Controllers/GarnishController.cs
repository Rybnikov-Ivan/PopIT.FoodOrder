using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using popIT.FoodOrder.Core.Garnishes;
using popIT.FoodOrder.Core.Garnishes.Requests;
using popIT.FoodOrder.Core.Garnishes.Responses;

namespace popIT.FoodOrder.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GarnishController : ControllerBase
    {
        private readonly IGarnishService _garnishService;

        public GarnishController(IGarnishService garnishService)
        {
            _garnishService = garnishService;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GarnishResponse>>> GetAllGarnishes()
        {
            var response = await _garnishService.GetAllGarnishes();

            return Ok(response);
        }
        
        [HttpGet("{id}", Name = "GetGarnishById")]
        public async Task<ActionResult<GarnishResponse>> GetGarnishById(int id)
        {
            var response = await _garnishService.GetGarnishById(id);

            return Ok(response);
        }
        
        [HttpPost]
        public async Task<ActionResult<GarnishResponse>> AddGarnish(GarnishAddRequest garnishAddRequest)
        {
            var response = await _garnishService.AddGarnish(garnishAddRequest);

            return CreatedAtRoute(nameof(GetGarnishById), new {Id = response.Id}, response);
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGarnish(int id, GarnishUpdateRequest garnishUpdateRequest)
        {
            await _garnishService.UpdateGarnish(id, garnishUpdateRequest);
            
            return NoContent();
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGarnish(int id)
        {
            await _garnishService.DeleteGarnish(id);
            
            return NoContent();
        }
    }
}