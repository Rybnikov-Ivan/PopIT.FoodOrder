using System.Collections.Generic;
using System.Threading.Tasks;
using popIT.FoodOrder.Core.Meats.Requests;
using popIT.FoodOrder.Core.Meats.Response;

namespace popIT.FoodOrder.Core.Meats
{
    public interface IMeatService
    {
        Task<IEnumerable<MeatResponse>> GetAllMeats();

        Task<MeatResponse> GetMeatById(int id);

        Task<MeatResponse> AddMeat(MeatAddRequest meatAddRequest);

        Task UpdateMeat(int id, MeatUpdateRequest meatUpdateRequest);

        Task DeleteMeat(int id);
    }
}