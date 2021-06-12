using System.Collections.Generic;
using System.Threading.Tasks;
using popIT.FoodOrder.Core.Soups.Requests;
using popIT.FoodOrder.Core.Soups.Response;

namespace popIT.FoodOrder.Core.Soups
{
    public class SoupService : ISoupService
    {
        public async Task<IEnumerable<SoupResponse>> GetAllSoups()
        {
            throw new System.NotImplementedException();
        }

        public async Task<SoupResponse> GetSoupById(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<SoupResponse> AddSoup(SoupAddRequest soupAddRequest)
        {
            throw new System.NotImplementedException();
        }

        public async Task UpdateSoup(int id, SoupUpdateRequest soupUpdateRequest)
        {
            throw new System.NotImplementedException();
        }

        public async Task DeleteSoup(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}