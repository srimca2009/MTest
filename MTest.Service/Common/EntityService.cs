using MTest.Repository.Common;
using System.Linq;

namespace MTest.Service.Common
{
    public abstract class EntityService<T> : IEntityService<T> where T : class
    {
        /// <summary>
        /// The _unit of work
        /// </summary>
        private IUnitOfWork _unitOfWork;

        /// <summary>
        /// The _repository
        /// </summary>
        private readonly IGenericRepository<T> _repository;

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="unitOfWork">The unit of work.</param>
        /// <param name="repository">The repository.</param>
        protected EntityService(IUnitOfWork unitOfWork, IGenericRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public virtual IQueryable<T> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
