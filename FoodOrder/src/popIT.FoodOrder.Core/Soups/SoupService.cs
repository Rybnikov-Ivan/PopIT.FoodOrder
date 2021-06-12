using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using popIT.FoodOrder.Core.General;
using popIT.FoodOrder.Core.Soups.Requests;
using popIT.FoodOrder.Core.Soups.Response;

namespace popIT.FoodOrder.Core.Soups
{
    public class SoupService : ISoupService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public SoupService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        
        public async Task<IEnumerable<SoupResponse>> GetAllSoups()
        {
            var soups = await _unitOfWork.GetRepository<ISoupRepository>().GetAllSoups();

            return _mapper.Map<IEnumerable<SoupResponse>>(soups);
        }

        public async Task<SoupResponse> GetSoupById(int id)
        {
            var soup = await _unitOfWork.GetRepository<ISoupRepository>().GetSoupById(id);

            return _mapper.Map<SoupResponse>(soup);
        }

        public async Task<SoupResponse> AddSoup(SoupAddRequest soupAddRequest)
        {
            var soup = _mapper.Map<Soup>(soupAddRequest);

            await _unitOfWork.GetRepository<ISoupRepository>().AddSoup(soup);
			
            return _mapper.Map<SoupResponse>(soup);
        }

        public async Task UpdateSoup(int id, SoupUpdateRequest soupUpdateRequest)
        {
            var soup = await _unitOfWork.GetRepository<ISoupRepository>().GetSoupById(id);

            _mapper.Map(soupUpdateRequest, soup);

            await _unitOfWork.GetRepository<ISoupRepository>().UpdateSoup(soup);
        }

        public async Task DeleteSoup(int id)
        {
            var soup = await _unitOfWork.GetRepository<ISoupRepository>().GetSoupById(id);
			
            await _unitOfWork.GetRepository<ISoupRepository>().DeleteSoup(soup);
        }
    }
}