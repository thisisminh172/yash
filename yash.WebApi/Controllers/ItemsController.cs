using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yash.Application.Catalog.Items;

namespace yash.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemsController(
            IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var items = await _itemService.GetAll();
            if (items.Count == 0)
                return BadRequest("Cannot find items");
            return Ok(items);
        }

        [HttpGet("{itemId}")]
        public async Task<IActionResult> GetById(int itemId)
        {
            var item = await _itemService.GetById(itemId);
            if(item == null)
            {
                return BadRequest("Cannot find item");
            }
            return Ok(item);
        }
        [HttpGet("SearchItem/{name}")]
        public async Task<IActionResult> SearchItem(string name)
        {
            var item = await _itemService.Search(name);
            if (item == null)
            {
                return BadRequest("Cannot find item!");
            }
            return Ok(item);
        }

        [HttpGet("GetAllImages/{itemId}")]
        public async Task<IActionResult> GetAllImages(int itemId)
        {
            var itemImages = await _itemService.GetAllImages(itemId);
            if (itemImages.Count == 0)
            {
                return BadRequest("Cannot find item");
            }
            return Ok(itemImages);
        }

        [HttpGet("GetItemsByCategory/{categoryId}")]
        public async Task<IActionResult> GetItemsByCategory(int categoryId)
        {
            var items = await _itemService.GetItemsByCategory(categoryId);
            if (items == null)
            {
                return BadRequest("Cannot find item!");
            }
            return Ok(items);
        }
    }
}
