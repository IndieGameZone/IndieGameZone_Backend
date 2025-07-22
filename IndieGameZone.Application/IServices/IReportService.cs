using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Reports;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Reports;

namespace IndieGameZone.Application.IServices
{
	public interface IReportService
	{
		Task CreateGameReport(Guid reportingUserId, ReportGameForCreationDto reportForCreationDto, CancellationToken ct = default);
		Task CreatePostReport(Guid reportingUserId, ReportPostForCreationDto reportForCreationDto, CancellationToken ct = default);
		Task CreateCommentReport(Guid reportingUserId, ReportCommentForCreationDto reportForCreationDto, CancellationToken ct = default);
		Task<(IEnumerable<ReportForReturnDto> reports, MetaData metaData)> GetReports(ReportParameters reportParameters, CancellationToken ct = default);
		Task<ReportForReturnDto> GetReportById(Guid id, CancellationToken ct = default);
		Task UpdateResolveStatus(Guid id, CancellationToken ct = default);
	}
}
