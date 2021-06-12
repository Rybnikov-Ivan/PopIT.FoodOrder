using System.Collections.Generic;
using System.Threading.Tasks;
using popIT.FoodOrder.Core.Beverages.Requests;
using popIT.FoodOrder.Core.Beverages.Responses;

namespace popIT.FoodOrder.Core.Beverages
{
	public interface IBeverageService
	{
		Task<IEnumerable<BeverageResponse>> GetAllBeverages();

		Task<BeverageResponse> GetBeverageById(int id);

		Task<BeverageResponse> AddBeverage(BeverageAddRequest beverageAddRequest);

		Task UpdateBeverage(int id, BeverageUpdateRequest beverageUpdateRequest);

		Task DeleteBeverage(int id);
	}
}
