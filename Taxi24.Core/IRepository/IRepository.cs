using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using Taxi24.Core.Common.IHandler;

namespace Taxi24.Core.IRepository
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null , bool AsNoTracking = false);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, bool AsNoTracking = false);
        Task<T> Get(int id);
        Task<int> AddAsync(T item);
        Task<int> AddRangeAsync(List<T> item);
        void Add(T item);
        Task<int> UpdateAsync(T item);
        void UpdateWithoutSave(T item);
        Task<int> DeleteAsync(T item);
        Task<int> DeleteAsync(Expression<Func<T, bool>> predicate, bool autoSave = false);
        Task<int> DeleteAsync(int id);
        Task<int> UpdateRangeAsync(List<T> item);
        Task<int> UpdateWithoutUserIdAsync(T item);

        bool Any(Expression<Func<T, bool>> predicate = null);

        (IQueryable<T>, int TotalNumRecoreds) GetAllWithCount(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
              Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
               int pageIndex = 1, int PageSize = 10);

        int? GetUserId();
        string? GetLang();

    }
}
