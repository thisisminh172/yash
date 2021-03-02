using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yash.Application.Catalog.Carts;
using yash.Data.Entities;
using yash.ViewModels.Catalog.Carts;

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
        public async Task<IActionResult> AddNewCart(CartViewModel newCart)
        {
            int result = await _cartService.AddNewCart(newCart);

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCart(CartViewModel updateCart)
        {
            var result = await _cartService.UpdateCart(updateCart);
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
