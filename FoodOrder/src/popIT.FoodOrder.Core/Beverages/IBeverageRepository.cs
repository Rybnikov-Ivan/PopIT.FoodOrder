using System.Collections.Generic;
using System.Threading.Tasks;

namespace popIT.FoodOrder.Core.Beverages
{
	public interface IBeverageRepository
	{
		Task<IEnumerable<Beverage>> GetAllBeverages();

		Task<Beverage> GetBeverageById(int id);

		Task AddBeverage(Beverage beverage);

		Task UpdateBeverage(Beverage beverage);

		Task DeleteBeverage(Beverage beverage);
	}
}
