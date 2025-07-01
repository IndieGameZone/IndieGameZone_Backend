using IndieGameZone.Application;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestsAndResponses.Requests.ReportReasons;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
	[Route("api/report-reasons")]
	[ApiController]
	public class ReportReasonsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public ReportReasonsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet]
		[Authorize]
		public async Task<IActionResult> GetReportReasons(CancellationToken ct)
		{
			var reportReasons = await serviceManager.ReportReasonService.GetReportReasons(ct);
			return Ok(reportReasons);
		}

		[HttpGet("{id:guid}")]
		[Authorize]
		public async Task<IActionResult> GetReportReason([FromRoute] Guid id, CancellationToken ct)
		{
			var reportReason = await serviceManager.ReportReasonService.GetReportReasonById(id, ct);
			return Ok(reportReason);
		}

		[HttpPost]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)}")]
		public async Task<IActionResult> CreateReportReason([FromBody] ReportReasonForCreationDto reportReasonDto, CancellationToken ct)
		{
			await serviceManager.ReportReasonService.CreateReportReason(reportReasonDto, ct);
			return StatusCode(201);
		}

		[HttpPut("{id:guid}")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)}")]
		public async Task<IActionResult> UpdateReportReason([FromRoute] Guid id, [FromBody] ReportReasonForUpdateDto reportReasonDto, CancellationToken ct)
		{
			await serviceManager.ReportReasonService.UpdateReportReason(id, reportReasonDto, ct);
			return NoContent();
		}

		[HttpDelete("{id:guid}")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)}")]
		public async Task<IActionResult> DeleteReportReason([FromRoute] Guid id, CancellationToken ct)
		{
			await serviceManager.ReportReasonService.DeleteReportReason(id, ct);
			return NoContent();
		}

	}
}
