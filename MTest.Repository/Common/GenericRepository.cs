using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace MTest.Repository.Common
{
    public class GenericRepository<T> : IGenericRepository<T> where T:class
    {
        /// <summary>
        /// The Dbset
        /// </summary>
        protected readonly DbSet<T> _currentDbSet;

        /// <summary>
        /// The DbContext
        /// </summary>
        protected DbContext _currentDbContext;

        /// <summary>
        /// Initializes a new instance of the TEntity class.
        /// </summary>
        /// <param name="context">The context.</param>
        protected GenericRepository(DbContext context)
        {
            _currentDbContext = context;
            try
            {
                _currentDbSet = _currentDbContext.Set<T>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public virtual IQueryable<T> GetAll()
        {
            var result = default(IQueryable<T>);
            try
            {
                result = _currentDbSet.AsNoTracking().AsParallel().AsQueryable();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
