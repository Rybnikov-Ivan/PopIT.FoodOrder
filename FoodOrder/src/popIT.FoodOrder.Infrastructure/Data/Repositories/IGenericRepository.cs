using Microsoft.EntityFrameworkCore.Query;
using popIT.FoodOrder.Core.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace popIT.FoodOrder.Infrastructure.Data.Repositories
{
	public interface IGenericRepository<TEntity>
	{
		Task Add(TEntity entity);

		Task Delete(TEntity entity);
		
		Task<IEnumerable<TEntity>> GetAll(
			Expression<Func<TEntity, bool>> predicate = null,
			Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
			Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null);

		Task<TEntity> GetById(
			int entityId,
			Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null);

		Task Update(TEntity entity);
	}
}
