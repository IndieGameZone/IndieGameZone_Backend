using IndieGameZone.Application;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Reports;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class ReportsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;

		public ReportsController(IServiceManager serviceManager)
		{
			this.serviceManager = serviceManager;
		}

		[HttpGet("reports")]
		public async Task<IActionResult> GetReports([FromQuery] ReportParameters reportParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.ReportService.GetReports(reportParameters, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.reports);
		}

		[HttpGet("reports/{id:guid}")]
		public async Task<IActionResult> GetReportById(Guid id, CancellationToken ct)
		{
			var report = await serviceManager.ReportService.GetReportById(id, ct);
			return Ok(report);
		}

		[HttpPost("users/{reportingUserId:guid}/reports")]
		public async Task<IActionResult> CreateReport([FromRoute] Guid reportingUserId, [FromBody] ReportForCreationDto reportForCreationDto, CancellationToken ct)
		{
			await serviceManager.ReportService.CreateReport(reportingUserId, reportForCreationDto, ct);
			return NoContent();
		}
	}
}
