using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Reports;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Reports;

namespace IndieGameZone.Application.ReportServices
{
	public interface IReportService
	{
		Task CreateReport(Guid reportingUserId, ReportForCreationDto reportForCreationDto, CancellationToken ct = default);
		Task<(IEnumerable<ReportForListReturnDto> reports, MetaData metaData)> GetReports(ReportParameters reportParameters, CancellationToken ct = default);
		Task<ReportForSingleReturnDto> GetReportById(Guid id, CancellationToken ct = default);
	}
}
