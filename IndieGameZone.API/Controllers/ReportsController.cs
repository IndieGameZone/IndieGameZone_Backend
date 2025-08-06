using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Reports;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
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
        [Authorize(Roles = $"{nameof(RoleEnum.Admin)},{nameof(RoleEnum.Moderator)}")]
        public async Task<IActionResult> GetReports([FromQuery] ReportParameters reportParameters, CancellationToken ct)
        {
            var pagedResult = await serviceManager.ReportService.GetReports(reportParameters, ct);
            Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
            return Ok(pagedResult.reports);
        }

        [HttpGet("reporting-users/{reportingUserId:guid}/reports")]
        [Authorize]
        public async Task<IActionResult> GetReportsByReportingUserId([FromRoute] Guid reportingUserId, [FromQuery] ReportParameters reportParameters, CancellationToken ct)
        {
            var pagedResult = await serviceManager.ReportService.GetReportsByReportingUserId(reportingUserId, reportParameters, ct);
            Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
            return Ok(pagedResult.reports);
        }

        [HttpGet("reported-users/{reportedUserId:guid}/reports")]
        [Authorize]
        public async Task<IActionResult> GetReportsByReportedUserId([FromRoute] Guid reportedUserId, [FromQuery] ReportParameters reportParameters, CancellationToken ct)
        {
            var pagedResult = await serviceManager.ReportService.GetReportsByReportedUserId(reportedUserId, reportParameters, ct);
            Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
            return Ok(pagedResult.reports);
        }

        [HttpGet("reports/{id:guid}")]
        [Authorize(Roles = $"{nameof(RoleEnum.Admin)},{nameof(RoleEnum.Moderator)}")]
        public async Task<IActionResult> GetReportById(Guid id, CancellationToken ct)
        {
            var report = await serviceManager.ReportService.GetReportById(id, ct);
            return Ok(report);
        }

        [HttpPost("users/{userId:guid}/game-reports")]
		[Authorize]
		public async Task<IActionResult> CreateGameReport([FromRoute] Guid userId, [FromBody] ReportGameForCreationDto reportForCreationDto, CancellationToken ct)
		{
			await serviceManager.ReportService.CreateGameReport(userId, reportForCreationDto, ct);
			return NoContent();
		}

		[HttpPost("users/{userId:guid}/post-reports")]
		[Authorize]
		public async Task<IActionResult> CreatePostReport([FromRoute] Guid userId, [FromBody] ReportPostForCreationDto reportForCreationDto, CancellationToken ct)
		{
			await serviceManager.ReportService.CreatePostReport(userId, reportForCreationDto, ct);
			return NoContent();
		}

		[HttpPost("users/{userId:guid}/comment-reports")]
		[Authorize]
		public async Task<IActionResult> CreateCommentReport([FromRoute] Guid userId, [FromBody] ReportCommentForCreationDto reportForCreationDto, CancellationToken ct)
		{
			await serviceManager.ReportService.CreateCommentReport(userId, reportForCreationDto, ct);
			return NoContent();
		}

		[HttpPatch("reports/{id:guid}/resolve-status")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)},{nameof(RoleEnum.Moderator)}")]
		public async Task<IActionResult> UpdateResolveStatus([FromRoute] Guid id,[Required] ReportStatus updatedStatus, [FromBody] ReportForUpdateStatusDto? dto, CancellationToken ct)
		{
			await serviceManager.ReportService.UpdateResolveStatus(id, updatedStatus, dto, ct);
			return NoContent();
		}
	}
}
