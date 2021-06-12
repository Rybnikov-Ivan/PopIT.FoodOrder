using System.Collections.Generic;
using System.Threading.Tasks;
using popIT.FoodOrder.Core.Meats.Requests;
using popIT.FoodOrder.Core.Meats.Response;

namespace popIT.FoodOrder.Core.Meats
{
    public class MeatService : IMeatService
    {
        public async Task<IEnumerable<MeatResponse>> GetAllMeats()
        {
            throw new System.NotImplementedException();
        }

        public async Task<MeatResponse> GetMeatById(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<MeatResponse> AddMeat(MeatAddRequest meatAddRequest)
        {
            throw new System.NotImplementedException();
        }

        public async Task UpdateMeat(int id, MeatUpdateRequest meatUpdateRequest)
        {
            throw new System.NotImplementedException();
        }

        public async Task DeleteMeat(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}