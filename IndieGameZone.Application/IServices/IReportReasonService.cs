using IndieGameZone.Domain.RequestsAndResponses.Requests.ReportReasons;
using IndieGameZone.Domain.RequestsAndResponses.Responses.ReportReasons;

namespace IndieGameZone.Application.IServices
{
	public interface IReportReasonService
	{
		Task<IEnumerable<ReportReasonForReturnDto>> GetReportReasons(CancellationToken ct = default);
		Task<ReportReasonForReturnDto?> GetReportReasonById(Guid id, CancellationToken ct = default);
		Task CreateReportReason(ReportReasonForCreationDto reportReasonDto, CancellationToken ct = default);
		Task UpdateReportReason(Guid id, ReportReasonForUpdateDto reportReasonDto, CancellationToken ct = default);
		Task DeleteReportReason(Guid id, CancellationToken ct = default);
	}
}
