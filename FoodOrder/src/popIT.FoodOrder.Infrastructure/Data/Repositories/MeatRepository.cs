using popIT.FoodOrder.Core.Meats;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace popIT.FoodOrder.Infrastructure.Data.Repositories
{
	public class MeatRepository : IMeatRepository
	{
		private readonly IGenericRepository<Meat> _genericRepository;

		public MeatRepository(IGenericRepository<Meat> genericRepository)
		{
			_genericRepository = genericRepository;
		}

		public async Task AddMeat(Meat meat)
		{
			await _genericRepository.Add(meat);
		}

		public async Task DeleteMeat(Meat meat)
		{
			await _genericRepository.Delete(meat);
		}

		public async Task<IEnumerable<Meat>> GetAllMeats()
		{
			return await _genericRepository.GetAll();
		}

		public async Task<Meat> GetMeatById(int id)
		{
			return await _genericRepository.GetById(id);
		}

		public async Task UpdateMeat(Meat meat)
		{
			await _genericRepository.Update(meat);
		}
	}
}
