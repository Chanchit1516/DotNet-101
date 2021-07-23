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
    public class OrderController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        IOrderService _orderService;
        public OrderController(IOrderService orderService, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrder()
        {
            var orderModel = await _orderService.GetAllOrder();
            return Ok(orderModel);
        }

        [HttpPost]
        public async Task<IActionResult> InsertOrder([FromBody] OrderDTO order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var res = await _orderService.InsertOrder(order);
            return Ok(res);
        }
    }
}