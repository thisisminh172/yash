using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yash.Application.Catalog.Certifications;
using yash.ViewModels.Catalog.Certifications;

namespace yash.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificationsController : ControllerBase
    {
        private readonly ICertificationService _certificationService;
        public CertificationsController(ICertificationService certificationService)
        {
            _certificationService = certificationService;
        }
        [HttpGet]
        public async Task<IActionResult> GetCertifications()
        {
            var listTemp = await _certificationService.GetAll();
            return Ok(listTemp);
        }
        [HttpGet("{CertificationId}")]
        public async Task<IActionResult> GetCertification(int CertificationId)
        {
            var temp = await _certificationService.GetById(CertificationId);
            return Ok(temp);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCertification(CertificationCreateRequest request)
        {
            var tempId = await _certificationService.Create(request);

            return Ok(tempId);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCertification(CertificationUpdateRequest request)
        {
            var result = await _certificationService.Update(request);
            return Ok(result);
        }
        [HttpDelete("{certificationId}")]
        public async Task<IActionResult> DeleteCertification(int certificationId)
        {
            var result = await _certificationService.Delete(certificationId);
            if (result == 0)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
