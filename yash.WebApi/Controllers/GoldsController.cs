using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yash.Application.Catalog.Golds;
using yash.ViewModels.Catalog.Golds;

namespace yash.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoldsController : ControllerBase
    {
        private readonly IGoldService _goldService;
        public GoldsController(IGoldService goldService)
        {
            _goldService = goldService;
        }




        [HttpGet]
        public async Task<IActionResult> GetGolds()
        {
            var listTemp = await _goldService.GetAll();
            return Ok(listTemp);
        }
        [HttpGet("{goldId}")]
        public async Task<IActionResult> GetGold(int goldId)
        {
            var temp = await _goldService.GetById(goldId);
            return Ok(temp);
        }

        [HttpPost]
        public async Task<IActionResult> CreateGold(GoldCreateRequest request)
        {
            var tempId = await _goldService.Create(request);

            return Ok(tempId);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateGold(GoldUpdateRequest request)
        {
            var result = await _goldService.Update(request);
            return Ok(result);
        }
        [HttpDelete("{goldId}")]
        public async Task<IActionResult> DeleteGold(int goldId)
        {
            var result = await _goldService.Delete(goldId);
            if (result == 0)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
