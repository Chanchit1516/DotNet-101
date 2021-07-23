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
            var productModel = await _productService.GetAllProduct();
            return Ok(productModel);
        }

        [HttpPost]
        public async Task<IActionResult> InsertProduct([FromBody] ProductDTO product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var res = await _productService.InsertProduct(product);
            return Ok(res);
        }

    }
}
