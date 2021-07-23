using System.Threading.Tasks;
using DotNet_101.Core.DTOs;
using DotNet_101.Core.Interfaces.Repository;
using DotNet_101.Core.Interfaces.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_101.Api.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    [Authorize]
    public class CustomerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        ICustomerService _customerService;
        public CustomerController(ICustomerService customerService, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _customerService = customerService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllCustomer()
        {
            var customerModel = await _customerService.GetAllCustomer();
            return Ok(customerModel);
        }

        [HttpPost]
        public async Task<IActionResult> InsertCustomer([FromBody] CustomerDTO customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var res = await _customerService.InsertCustomer(customer);
            return Ok(res);
        }
    }
}
