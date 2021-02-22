using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yash.Application.Catalog.ProductTypes;
using yash.ViewModels.Catalog.ProductTypes;

namespace yash.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypesController : ControllerBase
    {
        private readonly IProductTypeService _productTypeService;
        public ProductTypesController(IProductTypeService productTypeService)
        {
            _productTypeService = productTypeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductTypes()
        {
            var listTemp = await _productTypeService.GetAll();
            return Ok(listTemp);
        }
        [HttpGet("{productTypeId}")]
        public async Task<IActionResult> GetProductType(int productTypeId)
        {
            var temp = await _productTypeService.GetById(productTypeId);
            return Ok(temp);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductType(ProductTypeCreateRequest request)
        {
            var tempId = await _productTypeService.Create(request);

            return Ok(tempId);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProductType(ProductTypeUpdateRequest request)
        {
            var result = await _productTypeService.Update(request);
            return Ok(result);
        }
        [HttpDelete("{productTypeId}")]
        public async Task<IActionResult> DeleteProductType(int productTypeId)
        {
            var result = await _productTypeService.Delete(productTypeId);
            if (result == 0)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
