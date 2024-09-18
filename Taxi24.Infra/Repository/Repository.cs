using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Taxi24.Core.Common.IHandler;
using Taxi24.Core.Common.Utlities;
using Taxi24.Core.Entity;
using Taxi24.Core.IRepository;
using Taxi24.Infra.Data;


namespace Taxi24.Infra.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly StoreContext context;
        private readonly DbSet<T> dbSet;
        protected readonly IUserHandler userHandler;
        public Repository(StoreContext context, IUserHandler userHandler)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
            this.userHandler = userHandler;
        }

        public void Add(T item)
        {
            TimeZoneInfo ksaTimeZone = TimeZoneInfo.FindSystemTimeZoneById(Utlities.KSATimeZone);
            var creationDate = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, ksaTimeZone);
            item.GetType().GetProperty("CreationDate").SetValue(item, creationDate);
            item.GetType().GetProperty("CreationUser").SetValue(item, userHandler.GetUserId());
            dbSet.Add(item);
        }

        public async Task<int> AddAsync(T item)
        {
            TimeZoneInfo ksaTimeZone = TimeZoneInfo.FindSystemTimeZoneById(Utlities.KSATimeZone);
            var creationDate = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, ksaTimeZone);
            item.GetType().GetProperty("CreationDate").SetValue(item, creationDate);
            item.GetType().GetProperty("CreationUser").SetValue(item, userHandler.GetUserId());
            dbSet.Add(item);
            var result = await context.SaveChangesAsync();
            return result;
        }

        public async Task<int> AddRangeAsync(List<T> item)
        {
            item.ForEach(entity =>
            {
                entity.GetType().GetProperty("CreationDate").SetValue(entity, DateTime.Now);
                entity.GetType().GetProperty("CreationUser").SetValue(entity, userHandler.GetUserId());
            });
            await dbSet.AddRangeAsync(item);
            var result = await context.SaveChangesAsync();
            return result;
        }

        public async Task<int> UpdateRangeAsync(List<T> item)
        {
            item.ForEach(entity =>
            {
                entity.GetType().GetProperty("ModificationDate").SetValue(entity, DateTime.Now);
                //entity.GetType().GetProperty("ModificationUser").SetValue(entity, userHandler.GetUserId());
            });
            dbSet.UpdateRange(item);
            var result = await context.SaveChangesAsync();
            return result;
        }



        public async Task<int> DeleteAsync(T item)
        {

            dbSet.Remove(item);
            var result = await context.SaveChangesAsync();
            return  result;
        }
        public async Task<int> DeleteAsync(Expression<Func<T, bool>> predicate, bool autoSave = false)
        {
            var list = dbSet.Where(predicate);
            dbSet.RemoveRange(list);
            if (autoSave == true)
            {
                var result = await context.SaveChangesAsync();
                return  result;

            }
            return  0;
        }
        public async Task<int> DeleteAsync(int id)
        {
            try
            {
                T entity = await dbSet.FindAsync(id);
                if (entity == null)
                {
                    return 1;
                }

                entity.GetType().GetProperty("IsDeleted").SetValue(entity, true);
                dbSet.Update(entity);
                var result = await context.SaveChangesAsync();
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, bool AsNoTracking = false)
        {
            IQueryable<T> query = dbSet;
            if (include != null)
            {
                query = include(query);
            }
            if (AsNoTracking)
            {
                query = query.AsNoTracking();
            }
            if (predicate != null)
            {
                return await query.FirstOrDefaultAsync(predicate);
            }
            return await query.FirstOrDefaultAsync();
        }

        public async Task<T> Get(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await dbSet.ToListAsync();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = dbSet;

            if (include != null)
            {
                query = include(query);
            }

            if (predicate != null)
            {
                query = query.Where(predicate);
            }


            return query;
        }

        public (IQueryable<T> , int TotalNumRecoreds) GetAllWithCount(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
             int pageIndex = 1 , int PageSize = 10)
        {
            IQueryable<T> query = dbSet;

            if (include != null)
            {
                query = include(query);
            }

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if(orderBy != null)
            {
                query = orderBy(query);
            }
            return (query.Skip((pageIndex >= 1 ? pageIndex - 1 : 0) * PageSize).Take(PageSize), query.Count());
        }




        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, bool AsNoTracking = false)
        {
            IQueryable<T> query = dbSet;

            if (include != null)
            {
                query = include(query);
            }

            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            if (AsNoTracking)
            {
                query = query.AsNoTracking();
            }
            return await query.ToListAsync();
        }

        public async Task<int> UpdateAsync(T item)
        {
            dbSet.Update(item);
            item.GetType().GetProperty("ModificationDate").SetValue(item, DateTime.Now);
            item.GetType().GetProperty("ModificationUser").SetValue(item, userHandler.GetUserId());
            var result = await context.SaveChangesAsync();
            return result;
        }

        public async Task<int> UpdateWithoutUserIdAsync(T item)
        {
            dbSet.Update(item);
            item.GetType().GetProperty("ModificationDate").SetValue(item, DateTime.Now);
            var result = await context.SaveChangesAsync();
            return result;
        }



        public void UpdateWithoutSave(T item)
        {
            dbSet.Update(item);
            item.GetType().GetProperty("ModificationDate").SetValue(item, DateTime.Now);
            item.GetType().GetProperty("ModificationUser").SetValue(item, userHandler.GetUserId());
        }

        public void UpdateRageWithoutSaveAsync(List<T> item)
        {
            item.ForEach(entity =>
            {
                entity.GetType().GetProperty("ModificationDate").SetValue(entity, DateTime.Now);
                entity.GetType().GetProperty("ModificationUser").SetValue(entity, userHandler.GetUserId());
            });
            dbSet.UpdateRange(item);
        }

        public bool Any(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate != null) return dbSet.Any(predicate);
            return dbSet.Any();
        }

        public int? GetUserId() => userHandler.GetUserId();
        public string? GetLang() => userHandler.GetLanguage();
    }
}
