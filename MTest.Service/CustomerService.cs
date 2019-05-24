using MTest.Model;
using MTest.Repository;
using MTest.Repository.Common;
using MTest.Service.Common;

namespace MTest.Service
{
    public class CustomerService : EntityService<Customer>, ICustomerService
    {
        private IUnitOfWork _unitOfWork;
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(IUnitOfWork unitOfWork, ICustomerRepository customerRepository)
            : base(unitOfWork, customerRepository)
        {
            _unitOfWork = unitOfWork;
            _customerRepository = customerRepository;
        }
    }
}
