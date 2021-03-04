using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yash.Application.Catalog.Orders;
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

        [HttpPost]
        public async Task<IActionResult> Create(OrderCreateRequest request)
        {
            var result = await _orderService.Create(request);
            if (result > 0)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
