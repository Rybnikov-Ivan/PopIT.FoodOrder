using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using popIT.FoodOrder.Core.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace popIT.FoodOrder.Infrastructure.Data.Repositories
{
	public class GenericRepository<TEntity> : IGenericRepository<TEntity> 
		where TEntity : BaseEntity
	{
		private readonly DbSet<TEntity> _dbSet;

		public GenericRepository(DbSet<TEntity> dbSet)
		{
			_dbSet = dbSet;
		}

		public async Task Add(TEntity entity)
		{
			await _dbSet.AddAsync(entity);
		}

		public async Task Delete(TEntity entity)
		{
			await Task.Run(() => _dbSet.Remove(entity));
		}

		public async Task<IEnumerable<TEntity>> GetAll(
			Expression<Func<TEntity, bool>> predicate = null,
			Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
			Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null)
		{
			IQueryable<TEntity> query = _dbSet;
			if (include != null)
			{
				query = include(query);
			}

			if (predicate != null)
			{
				query = query.Where(predicate);
			}

			if (orderBy != null)
			{
				return await orderBy(query).ToListAsync();
			}

			return await query.ToListAsync();
		}

		public async Task<TEntity> GetById(
			int entityId,
			Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null)
		{
			IQueryable<TEntity> query = _dbSet;
			if (include != null)
			{
				query = include(query);
			}

			return await query.FirstOrDefaultAsync(e => e.Id == entityId);
		}

		public async Task Update(TEntity entity)
		{
			await Task.Run(() => _dbSet.Update(entity));
		}
	}
}
