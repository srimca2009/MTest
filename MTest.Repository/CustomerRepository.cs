using Microsoft.EntityFrameworkCore;
using MTest.Model;
using MTest.Repository.Common;

namespace MTest.Repository
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DbContext context)
           : base(context)
        {
        }
    }
}
