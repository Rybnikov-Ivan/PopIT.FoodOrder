using popIT.FoodOrder.Core.Garnishes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace popIT.FoodOrder.Infrastructure.Data.Repositories
{
	public class GarnishRepository : IGarnishRepository
	{
		private readonly IGenericRepository<Garnish> _genericRepository;

		public GarnishRepository(IGenericRepository<Garnish> genericRepository)
		{
			_genericRepository = genericRepository;
		}

		public async Task AddGarnish(Garnish garnish)
		{
			await _genericRepository.Add(garnish);
		}

		public async Task DeleteGarnish(Garnish garnish)
		{
			await _genericRepository.Delete(garnish);
		}

		public async Task<IEnumerable<Garnish>> GetAllGarnish()
		{
			return await _genericRepository.GetAll();
		}

		public async Task<Garnish> GetGarnishById(int id)
		{
			return await _genericRepository.GetById(id);
		}

		public async Task UpdateGarnish(Garnish garnish)
		{
			await _genericRepository.Update(garnish);
		}
	}
}
