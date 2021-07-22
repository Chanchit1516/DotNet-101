using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNet_101.Core.DTOs;
using DotNet_101.Core.Entities;
using DotNet_101.Core.Interfaces.Repository;
using DotNet_101.Core.Interfaces.Service;
using DotNet_101.Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNet_101.Api.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        IProductService _productService;

        public ProductController(IProductService productService, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            var productModel = await _productService.GetAllCustomer();
            return Ok(productModel);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomer()
        {
            var customerModel = await _productService.GetAllCustomer();
            return Ok(customerModel);
        }

        [HttpPost]
        public async Task<IActionResult> InsertCustomer([FromBody] CustomerDTO customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var model = new Customer();
            model.CompanyName = customer.CompanyName;
            model.ContactTitle = customer.ContactTitle;
            model.Phone = customer.Phone;
            model.Country = customer.Country;
            model.CreatedBy = 0;
            await _unitOfWork.CustomerRepository.Add(model);
            await _unitOfWork.CompleteAsync();
            return Ok();
        }

    }
}
