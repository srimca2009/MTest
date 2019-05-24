using System.Linq;

namespace MTest.Service.Common
{
    /// <summary>
    /// IEntityService
    /// </summary>
    /// <typeparam name="T">The type of the entity.</typeparam>
    public interface IEntityService<T> where T : class
    {
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetAll();
    }
}
