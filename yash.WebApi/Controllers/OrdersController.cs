using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yash.Application.Catalog.Orders;
using yash.Data.Entities;
using yash.ViewModels.Catalog.Orders;

namespace yash.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(OrderCreateRequest request)
        {
            var result = await _orderService.Create(request);
            if (result > 0)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _orderService.GetAll();
            return Ok(result);
        }
        [HttpPut("UpdateOrder")]
        public async Task<IActionResult> UpdateOrder(Order request)
        {
            var result = await _orderService.UpdateOrder(request);
            if (result > 0)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("GetAllOrderDetail/{orderId}")]
        public async Task<IActionResult> GetAllOrderDetail(int orderId)
        {
            var result = await _orderService.GetAllOrderDetail(orderId);
            return Ok(result);
        }

        [HttpGet("GetAllOrderData")]
        public async Task<IActionResult> GetAllOrderData()
        {
            var result = await _orderService.GetAllOrderData();
            return Ok(result);
        }
    }
}
