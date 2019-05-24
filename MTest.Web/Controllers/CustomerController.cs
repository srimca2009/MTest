using Microsoft.AspNetCore.Mvc;
using MTest.Model;
using MTest.Service;
using System.Linq;

namespace MTest.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("GetAll")]
        public IQueryable<Customer> GetAll()
        {
            return _customerService.GetAll();
        }
    }
}