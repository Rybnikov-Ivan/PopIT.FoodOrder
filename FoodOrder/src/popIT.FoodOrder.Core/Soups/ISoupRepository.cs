using System.Collections.Generic;
using System.Threading.Tasks;

namespace popIT.FoodOrder.Core.Soups
{
	public interface ISoupRepository
    {
        Task<IEnumerable<Soup>> GetAllSoups();

        Task<Soup> GetSoupById(int id);

        Task AddSoup(Soup soup);

        Task UpdateSoup(Soup soup);

        Task DeleteSoup(Soup soup);
    }
}