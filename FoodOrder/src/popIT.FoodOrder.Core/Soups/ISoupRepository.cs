using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;

namespace popIT.FoodOrder.Core.Soups
{
    public interface ISoupRepository
    {
        Task<IEnumerable<Soup>> GetAllSoups(
            Expression<Func<Soup, bool>> predicate = null,
            Func<IQueryable<Soup>, IOrderedQueryable<Soup>> orderBy = null,
            Func<IQueryable<Soup>, IIncludableQueryable<Soup, object>> include = null,
            bool disableTracking = true
        );

        Task<Soup> GetSoupById(
            Guid id,
            Func<IQueryable<Soup>, IIncludableQueryable<Soup, object>> include = null,
            bool disableTracking = true
        );

        Task AddSoup(Soup meat);

        Task UpdateSoup(Soup meat);

        Task DeleteSoup(Soup meat);
    }
}