using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using popIT.FoodOrder.Core.Garnishes.Requests;
using popIT.FoodOrder.Core.Garnishes.Responses;

namespace popIT.FoodOrder.Core.Garnishes
{
	public class GarnishService : IGarnishService
	{
		public async Task<IEnumerable<GarnishResponse>> GetAllGarnishes()
		{
			throw new NotImplementedException();
		}

		public async Task<GarnishResponse> GetGarnishById(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<GarnishResponse> AddGarnish(GarnishAddRequest garnishAddRequest)
		{
			throw new NotImplementedException();
		}

		public async Task UpdateGarnish(int id, GarnishUpdateRequest garnishUpdateRequest)
		{
			throw new NotImplementedException();
		}

		public async Task DeleteGarnish(int id)
		{
			throw new NotImplementedException();
		}
	}
}
