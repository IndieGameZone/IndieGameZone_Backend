using IndieGameZone.Domain.Constants;
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
        Task<(IEnumerable<object> reports, MetaData metaData)> GetReports(ReportParameters reportParameters, CancellationToken ct = default);
        Task<object> GetReportById(Guid id, CancellationToken ct = default);
        Task UpdateResolveStatus(Guid id, ReportStatus updatedStatus, ReportForUpdateStatusDto? dto, CancellationToken ct = default);
        Task<(IEnumerable<object> reports, MetaData metaData)> GetReportsByReportingUserId(Guid reportingUserId, ReportParameters reportParameters, CancellationToken ct = default);
        Task<(IEnumerable<object> reports, MetaData metaData)> GetReportsByReportedUserId(Guid reportedUserId, ReportParameters reportParameters, CancellationToken ct = default);
    }
}
