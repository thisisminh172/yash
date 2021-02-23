﻿using Microsoft.AspNetCore.Http;
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

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetCategories(int userId)
        {
            var carts = await _cartService.GetAll(userId);
            return Ok(carts);
        }
        [HttpGet("{cartId}")]
        public async Task<IActionResult> GetCart(int cartId)
        {
            var cart = await _cartService.GetById(cartId);
            return Ok(cart);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCart(int itemId)
        {
            var result = await _cartService.AddNewCart(itemId);

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(Cart cart)
        {
            var result = await _cartService.UpdateCart(cart);
            return Ok(result);
        }
        [HttpDelete("{cartId}")]
        public async Task<IActionResult> DeleteCategory(int cartId)
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
