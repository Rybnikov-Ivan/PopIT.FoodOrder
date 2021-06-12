using Microsoft.Extensions.DependencyInjection;
using popIT.FoodOrder.Core.General;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace popIT.FoodOrder.Infrastructure.Data.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly FoodOrderDbContext _universityDbContext;
		private readonly IServiceProvider _serviceProvider;

		public UnitOfWork(FoodOrderDbContext universityDbContext, IServiceProvider serviceProvider)
		{
			_universityDbContext = universityDbContext;
			_serviceProvider = serviceProvider;
		}

		public async Task SaveChangesAsync()
		{
			await _universityDbContext.SaveChangesAsync();
		}

		public TRepository GetRepository<TRepository>()
		{
			return _serviceProvider.GetRequiredService<TRepository>();
		}
	}
}
