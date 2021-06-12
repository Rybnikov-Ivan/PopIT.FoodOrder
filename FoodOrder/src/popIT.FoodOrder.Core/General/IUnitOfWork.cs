using System.Threading.Tasks;

namespace popIT.FoodOrder.Core.General
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync();

        TRepository GetRepository<TRepository>();
    }
}