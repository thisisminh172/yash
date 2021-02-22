using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yash.Application.Catalog.RingSizes;
using yash.ViewModels.Catalog.RingSizes;

namespace yash.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RingSizesController : ControllerBase
    {
        private readonly IRingSizeService _ringSizeService;
        public RingSizesController(IRingSizeService ringSizeService)
        {
            _ringSizeService = ringSizeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetRingSizes()
        {
            var listTemp = await _ringSizeService.GetAll();
            return Ok(listTemp);
        }
        [HttpGet("{ringSizeId}")]
        public async Task<IActionResult> GetRingSize(int ringSizeId)
        {
            var temp = await _ringSizeService.GetById(ringSizeId);
            return Ok(temp);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRingSize(RingSizeCreateRequest request)
        {
            var tempId = await _ringSizeService.Create(request);

            return Ok(tempId);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRingSize(RingSizeUpdateRequest request)
        {
            var result = await _ringSizeService.Update(request);
            return Ok(result);
        }
        [HttpDelete("{ringSizeId}")]
        public async Task<IActionResult> DeleteRingSize(int ringSizeId)
        {
            var result = await _ringSizeService.Delete(ringSizeId);
            if (result == 0)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
