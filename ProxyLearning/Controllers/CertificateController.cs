using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProxyLearning.Interfaces.Services;
using ProxyLearning.Models.DTOs;

namespace ProxyLearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificateController : ControllerBase
    {
        private readonly ICertificateService _certificateService;

        public CertificateController(ICertificateService certificateService)
        {
            _certificateService = certificateService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var certificate = await _certificateService.GetAsync(id);
            return Ok(certificate);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CertificateCreationRequest certificateCreationRequest)
        {
            await _certificateService.SaveAsync(
                certificateCreationRequest.OwnerId,
                certificateCreationRequest.CertificateBase64
            );
            
            return Created(
                new Uri($"/api/certificate/{certificateCreationRequest.OwnerId}", UriKind.Relative), 
                certificateCreationRequest.OwnerId
            );
        }

        // [HttpPut("{id}")]
        // public async Task<IActionResult> Put(int id, [FromBody] Certificate certificate)
        // {
        //     var updatedCertificate = await _certificateService.UpdateCertificate(id, certificate);
        //     return Ok(updatedCertificate);
        // }

        // [HttpDelete("{id}")]
        // public async Task<IActionResult> Delete(int id)
        // {
        //     await _certificateService.DeleteCertificate(id);
        //     return Ok();
        // }
    }
}
