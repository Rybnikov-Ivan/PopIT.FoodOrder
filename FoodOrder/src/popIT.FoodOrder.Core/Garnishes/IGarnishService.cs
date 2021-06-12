using System.Collections.Generic;
using System.Threading.Tasks;
using popIT.FoodOrder.Core.Garnishes.Requests;
using popIT.FoodOrder.Core.Garnishes.Responses;

namespace popIT.FoodOrder.Core.Garnishes
{
	public interface IGarnishService
	{
		Task<IEnumerable<GarnishResponse>> GetAllGarnishes();

		Task<GarnishResponse> GetGarnishById(int id);

		Task<GarnishResponse> AddGarnish(GarnishAddRequest garnishAddRequest);

		Task UpdateGarnish(int id, GarnishUpdateRequest garnishUpdateRequest);

		Task DeleteGarnish(int id);
	}
}
