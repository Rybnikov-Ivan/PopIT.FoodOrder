using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using popIT.FoodOrder.Core.Exceptions;
using popIT.FoodOrder.Core.Garnishes.Requests;
using popIT.FoodOrder.Core.Garnishes.Responses;
using popIT.FoodOrder.Core.General;

namespace popIT.FoodOrder.Core.Garnishes
{
	public class GarnishService : IGarnishService
	{
		private readonly IMapper _mapper;
		private readonly IUnitOfWork _unitOfWork;

		public GarnishService(IMapper mapper, IUnitOfWork unitOfWork)
		{
			_mapper = mapper;
			_unitOfWork = unitOfWork;
		}
		
		public async Task<IEnumerable<GarnishResponse>> GetAllGarnishes()
		{
			var garnishes = await _unitOfWork.GetRepository<IGarnishRepository>().GetAllGarnish();

			return _mapper.Map<IEnumerable<GarnishResponse>>(garnishes);
		}

		public async Task<GarnishResponse> GetGarnishById(int id)
		{
			var garnish = await _unitOfWork.GetRepository<IGarnishRepository>().GetGarnishById(id);
			
			if (garnish == null)
			{
				throw new EntityIdNotFoundException(nameof(Garnish), id);
			}

			return _mapper.Map<GarnishResponse>(garnish);
		}

		public async Task<GarnishResponse> AddGarnish(GarnishAddRequest garnishAddRequest)
		{
			var garnish = _mapper.Map<Garnish>(garnishAddRequest);

			await _unitOfWork.GetRepository<IGarnishRepository>().AddGarnish(garnish);
			await _unitOfWork.SaveChangesAsync();
			
			return _mapper.Map<GarnishResponse>(garnish);
		}

		public async Task UpdateGarnish(int id, GarnishUpdateRequest garnishUpdateRequest)
		{
			var garnish = await _unitOfWork.GetRepository<IGarnishRepository>().GetGarnishById(id);
			
			if (garnish == null)
			{
				throw new EntityIdNotFoundException(nameof(Garnish), id);
			}

			_mapper.Map(garnishUpdateRequest, garnish);

			await _unitOfWork.GetRepository<IGarnishRepository>().UpdateGarnish(garnish);
			await _unitOfWork.SaveChangesAsync();
		}

		public async Task DeleteGarnish(int id)
		{
			var garnish = await _unitOfWork.GetRepository<IGarnishRepository>().GetGarnishById(id);
			
			if (garnish == null)
			{
				throw new EntityIdNotFoundException(nameof(Garnish), id);
			}
			
			await _unitOfWork.GetRepository<IGarnishRepository>().DeleteGarnish(garnish);
			await _unitOfWork.SaveChangesAsync();
		}
	}
}
