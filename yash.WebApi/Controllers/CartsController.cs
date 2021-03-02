using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yash.Application.Catalog.Carts;
using yash.Data.Entities;

namespace yash.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        private readonly ICartService _cartService;
        public CartsController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpGet("GetCarts/{userId}")]
        public IActionResult GetCarts(int userId)
        {
            var carts = _cartService.GetAll(userId);
            return Ok(carts);
        }
        [HttpGet("GetCart/{cartId}")]
        public async Task<IActionResult> GetCart(int cartId)
        {
            var cart = await _cartService.GetById(cartId);
            return Ok(cart);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewCart(int itemId, int userId)
        {
            var result = await _cartService.AddNewCart(itemId, userId);

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCart(int cartId, int quantity)
        {
            var result = await _cartService.UpdateCart(cartId, quantity);
            return Ok(result);
        }
        [HttpDelete("{cartId}")]
        public async Task<IActionResult> DeleteCart(int cartId)
        {
            var result = await _cartService.DeleteCart(cartId);
            if (result == 0)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
