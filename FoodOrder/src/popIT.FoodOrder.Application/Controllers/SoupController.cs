using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using popIT.FoodOrder.Core.Soups;
using popIT.FoodOrder.Core.Soups.Requests;
using popIT.FoodOrder.Core.Soups.Response;

namespace popIT.FoodOrder.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SoupController : ControllerBase
    {
        private readonly ISoupService _soupService;

        public SoupController(ISoupService soupService)
        {
            _soupService = soupService;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SoupResponse>>> GetAllSoups()
        {
            var response = await _soupService.GetAllSoups();

            return Ok(response);
        }
        
        [HttpGet("{id}", Name = "GetSoupById")]
        public async Task<ActionResult<SoupResponse>> GetSoupById(int id)
        {
            var response = await _soupService.GetSoupById(id);

            return Ok(response);
        }
        
        [HttpPost]
        public async Task<ActionResult<SoupResponse>> AddSoup(SoupAddRequest soupAddRequest)
        {
            var response = await _soupService.AddSoup(soupAddRequest);

            return CreatedAtRoute(nameof(GetSoupById), new {Id = response.Id}, response);
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSoup(int id, SoupUpdateRequest soupUpdateRequest)
        {
            await _soupService.UpdateSoup(id, soupUpdateRequest);
            
            return NoContent();
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSoup(int id)
        {
            await _soupService.DeleteSoup(id);
            
            return NoContent();
        }
    }
}