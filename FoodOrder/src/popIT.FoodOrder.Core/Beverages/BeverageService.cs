using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using popIT.FoodOrder.Core.Beverages.Requests;
using popIT.FoodOrder.Core.Beverages.Responses;

namespace popIT.FoodOrder.Core.Beverages
{
	public class BeverageService : IBeverageService
	{
		public async Task<IEnumerable<BeverageResponse>> GetAllBeverages()
		{
			throw new NotImplementedException();
		}

		public async Task<BeverageResponse> GetBeverageById(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<BeverageResponse> AddBeverage(BeverageAddRequest beverageAddRequest)
		{
			throw new NotImplementedException();
		}

		public async Task UpdateBeverage(int id, BeverageUpdateRequest beverageUpdateRequest)
		{
			throw new NotImplementedException();
		}

		public async Task DeleteBeverage(int id)
		{
			throw new NotImplementedException();
		}
	}
}
