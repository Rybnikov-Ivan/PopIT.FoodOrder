using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;

namespace popIT.FoodOrder.Core.Meats
{
    public interface IMeatRepository
    {
        Task<IEnumerable<Meat>> GetAllMeats(
            Expression<Func<Meat, bool>> predicate = null,
            Func<IQueryable<Meat>, IOrderedQueryable<Meat>> orderBy = null,
            Func<IQueryable<Meat>, IIncludableQueryable<Meat, object>> include = null,
            bool disableTracking = true
        );

        Task<Meat> GetMeatById(
            Guid id,
            Func<IQueryable<Meat>, IIncludableQueryable<Meat, object>> include = null,
            bool disableTracking = true
        );

        Task AddMeat(Meat meat);

        Task UpdateMeat(Meat meat);

        Task DeleteMeat(Meat meat);
    }
}