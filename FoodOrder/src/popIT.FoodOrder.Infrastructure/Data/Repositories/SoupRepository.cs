using popIT.FoodOrder.Core.Soups;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace popIT.FoodOrder.Infrastructure.Data.Repositories
{
	public class SoupRepository : ISoupRepository
	{
		private readonly IGenericRepository<Soup> _genericRepository;

		public SoupRepository(IGenericRepository<Soup> genericRepository)
		{
			_genericRepository = genericRepository;
		}

		public async Task AddSoup(Soup soup)
		{
			await _genericRepository.Add(soup);
		}

		public async Task DeleteSoup(Soup soup)
		{
			await _genericRepository.Delete(soup);
		}

		public async Task<IEnumerable<Soup>> GetAllSoups()
		{
			return await _genericRepository.GetAll();
		}

		public async Task<Soup> GetSoupById(int id)
		{
			return await _genericRepository.GetById(id);
		}

		public async Task UpdateSoup(Soup soup)
		{
			await _genericRepository.Update(soup);
		}
	}
}
