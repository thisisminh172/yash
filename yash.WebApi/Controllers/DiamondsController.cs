using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yash.Application.Catalog.Diamonds;
using yash.ViewModels.Catalog.Diamonds;

namespace yash.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiamondsController : ControllerBase
    {
        private readonly IDiamondService _diamondService;
        public DiamondsController(IDiamondService diamondService)
        {
            _diamondService = diamondService;
        }



        [HttpGet]
        public async Task<IActionResult> GetDiamonds()
        {
            var listTemp = await _diamondService.GetAll();
            return Ok(listTemp);
        }
        [HttpGet("{diamondId}")]
        public async Task<IActionResult> GetDiamond(int diamondId)
        {
            var temp = await _diamondService.GetById(diamondId);
            return Ok(temp);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDiamond(DiamondCreateRequest request)
        {
            var tempId = await _diamondService.Create(request);

            return Ok(tempId);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDiamond(DiamondUpdateRequest request)
        {
            var result = await _diamondService.Update(request);
            return Ok(result);
        }
        [HttpDelete("{diamondId}")]
        public async Task<IActionResult> DeleteDiamond(int diamondId)
        {
            var result = await _diamondService.Delete(diamondId);
            if (result == 0)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
