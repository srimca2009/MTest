using System.Linq;

namespace MTest.Repository.Common
{
    public interface IGenericRepository<T> where T : class
    {
        /// <summary>
        /// Get All Records
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetAll();
    }
}
