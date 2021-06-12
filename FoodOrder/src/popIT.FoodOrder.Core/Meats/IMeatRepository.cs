using System.Collections.Generic;
using System.Threading.Tasks;

namespace popIT.FoodOrder.Core.Meats
{
	public interface IMeatRepository
    {
        Task<IEnumerable<Meat>> GetAllMeats();

        Task<Meat> GetMeatById(int id);

        Task AddMeat(Meat meat);

        Task UpdateMeat(Meat meat);

        Task DeleteMeat(Meat meat);
    }
}