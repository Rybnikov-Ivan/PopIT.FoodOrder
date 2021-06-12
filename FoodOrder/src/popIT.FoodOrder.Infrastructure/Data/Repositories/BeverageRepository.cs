using popIT.FoodOrder.Core.Beverages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace popIT.FoodOrder.Infrastructure.Data.Repositories
{
	public class BeverageRepository : IBeverageRepository
	{
		private readonly IGenericRepository<Beverage> _genericRepository;

		public BeverageRepository(IGenericRepository<Beverage> genericRepository)
		{
			_genericRepository = genericRepository;
		}

		public async Task AddBeverage(Beverage beverage)
		{
			await _genericRepository.Add(beverage);
		}

		public async Task DeleteBeverage(Beverage beverage)
		{
			await _genericRepository.Delete(beverage);
		}

		public async Task<IEnumerable<Beverage>> GetAllBeverages()
		{
			return await _genericRepository.GetAll();
		}

		public async Task<Beverage> GetBeverageById(int id)
		{
			return await _genericRepository.GetById(id);
		}

		public Task UpdateBeverage(Beverage beverage)
		{
			throw new NotImplementedException();
		}
	}
}
