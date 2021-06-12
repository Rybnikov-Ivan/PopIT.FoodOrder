using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using popIT.FoodOrder.Core.Beverages.Requests;
using popIT.FoodOrder.Core.Beverages.Responses;
using popIT.FoodOrder.Core.Exceptions;
using popIT.FoodOrder.Core.General;

namespace popIT.FoodOrder.Core.Beverages
{
	public class BeverageService : IBeverageService
	{
		private readonly IMapper _mapper;
		private readonly IUnitOfWork _unitOfWork;

		public BeverageService(IMapper mapper, IUnitOfWork unitOfWork)
		{
			_mapper = mapper;
			_unitOfWork = unitOfWork;
		}
		
		public async Task<IEnumerable<BeverageResponse>> GetAllBeverages()
		{
			var beverages = await _unitOfWork.GetRepository<IBeverageRepository>().GetAllBeverages();

			return _mapper.Map<IEnumerable<BeverageResponse>>(beverages);
		}

		public async Task<BeverageResponse> GetBeverageById(int id)
		{
			var beverage = await _unitOfWork.GetRepository<IBeverageRepository>().GetBeverageById(id);
			
			if (beverage == null)
			{
				throw new EntityIdNotFoundException(nameof(Beverage), id);
			}

			return _mapper.Map<BeverageResponse>(beverage);
		}

		public async Task<BeverageResponse> AddBeverage(BeverageAddRequest beverageAddRequest)
		{
			var beverage = _mapper.Map<Beverage>(beverageAddRequest);

			await _unitOfWork.GetRepository<IBeverageRepository>().AddBeverage(beverage);
			
			return _mapper.Map<BeverageResponse>(beverage);
		}

		public async Task UpdateBeverage(int id, BeverageUpdateRequest beverageUpdateRequest)
		{
			var beverage = await _unitOfWork.GetRepository<IBeverageRepository>().GetBeverageById(id);
			
			if (beverage == null)
			{
				throw new EntityIdNotFoundException(nameof(Beverage), id);
			}

			_mapper.Map(beverageUpdateRequest, beverage);

			await _unitOfWork.GetRepository<IBeverageRepository>().UpdateBeverage(beverage);
		}

		public async Task DeleteBeverage(int id)
		{
			var beverage = await _unitOfWork.GetRepository<IBeverageRepository>().GetBeverageById(id);
			
			if (beverage == null)
			{
				throw new EntityIdNotFoundException(nameof(Beverage), id);
			}

			await _unitOfWork.GetRepository<IBeverageRepository>().DeleteBeverage(beverage);
		}
	}
}
