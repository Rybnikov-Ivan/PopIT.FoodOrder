using System.Collections.Generic;
using System.Threading.Tasks;

namespace popIT.FoodOrder.Core.Garnishes
{
	public interface IGarnishRepository
	{
		Task<IEnumerable<Garnish>> GetAllGarnish();

		Task<Garnish> GetGarnishById(int id);

		Task AddGarnish(Garnish garnish);

		Task UpdateGarnish(Garnish garnish);

		Task DeleteGarnish(Garnish garnish);
	}
}
