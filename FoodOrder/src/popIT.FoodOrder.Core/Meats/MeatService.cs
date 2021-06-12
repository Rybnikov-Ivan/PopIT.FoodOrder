using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using popIT.FoodOrder.Core.Exceptions;
using popIT.FoodOrder.Core.General;
using popIT.FoodOrder.Core.Meats.Requests;
using popIT.FoodOrder.Core.Meats.Response;

namespace popIT.FoodOrder.Core.Meats
{
    public class MeatService : IMeatService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public MeatService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        
        public async Task<IEnumerable<MeatResponse>> GetAllMeats()
        {
            var meats = await _unitOfWork.GetRepository<IMeatRepository>().GetAllMeats();

            return _mapper.Map<IEnumerable<MeatResponse>>(meats);
        }

        public async Task<MeatResponse> GetMeatById(int id)
        {
            var meat = await _unitOfWork.GetRepository<IMeatRepository>().GetMeatById(id);
            
            if (meat == null)
            {
                throw new EntityIdNotFoundException(nameof(Meat), id);
            }

            return _mapper.Map<MeatResponse>(meat);
        }

        public async Task<MeatResponse> AddMeat(MeatAddRequest meatAddRequest)
        {
            var meat = _mapper.Map<Meat>(meatAddRequest);

            await _unitOfWork.GetRepository<IMeatRepository>().AddMeat(meat);
            await _unitOfWork.SaveChangesAsync();
			
            return _mapper.Map<MeatResponse>(meat);
        }

        public async Task UpdateMeat(int id, MeatUpdateRequest meatUpdateRequest)
        {
            var meat = await _unitOfWork.GetRepository<IMeatRepository>().GetMeatById(id);
            
            if (meat == null)
            {
                throw new EntityIdNotFoundException(nameof(Meat), id);
            }

            _mapper.Map(meatUpdateRequest, meat);

            await _unitOfWork.GetRepository<IMeatRepository>().UpdateMeat(meat);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteMeat(int id)
        {
            var meat = await _unitOfWork.GetRepository<IMeatRepository>().GetMeatById(id);
            
            if (meat == null)
            {
                throw new EntityIdNotFoundException(nameof(Meat), id);
            }
			
            await _unitOfWork.GetRepository<IMeatRepository>().DeleteMeat(meat);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}