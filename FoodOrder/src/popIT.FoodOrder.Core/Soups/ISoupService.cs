using System.Collections.Generic;
using System.Threading.Tasks;
using popIT.FoodOrder.Core.Soups.Requests;
using popIT.FoodOrder.Core.Soups.Response;

namespace popIT.FoodOrder.Core.Soups
{
    public interface ISoupService
    {
        Task<IEnumerable<SoupResponse>> GetAllSoups();

        Task<SoupResponse> GetSoupById(int id);

        Task<SoupResponse> AddSoup(SoupAddRequest soupAddRequest);

        Task UpdateSoup(int id, SoupUpdateRequest soupUpdateRequest);

        Task DeleteSoup(int id);
    }
}