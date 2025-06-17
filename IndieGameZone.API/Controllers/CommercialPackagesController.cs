using IndieGameZone.Application;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Achievements;
using IndieGameZone.Domain.RequestsAndResponses.Requests.CommercialPackages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace IndieGameZone.API.Controllers
{
    [Route("api/commercial-packages")]
    [ApiController]
    public class CommercialPackagesController : ControllerBase
    {
        private readonly IServiceManager serviceManager;

        public CommercialPackagesController(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetCommercialPackages([FromQuery] CommercialPackageParameters commercialPackageParameters, CancellationToken ct)
        {
            var pagedResult = await serviceManager.CommercialPackageService.GetCommercialPackages(commercialPackageParameters, ct);
            Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
            return Ok(pagedResult.commercialPackages);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetCommercialPackageById([FromRoute] Guid id, CancellationToken ct)
        {
            var commercialPackage = await serviceManager.CommercialPackageService.GetCommercialPackageById(id, ct);
            return Ok(commercialPackage);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCommercialPackage([FromBody] CommercialPackageForCreationDto commercialPackageForCreationDto, CancellationToken ct)
        {
            await serviceManager.CommercialPackageService.CreateCommercialPackage(commercialPackageForCreationDto, ct);
            return StatusCode(201);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateCommercialPackage([FromRoute] Guid id, [FromBody] CommercialPackageForUpdateDto commercialPackageForUpdateDto, CancellationToken ct)
        {
            await serviceManager.CommercialPackageService.UpdateCommercialPackage(id, commercialPackageForUpdateDto, ct);
            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteCommercialPackage([FromRoute] Guid id, CancellationToken ct)
        {
            await serviceManager.CommercialPackageService.DeleteCommercialPackage(id, ct);
            return NoContent();
        }
    }
}
