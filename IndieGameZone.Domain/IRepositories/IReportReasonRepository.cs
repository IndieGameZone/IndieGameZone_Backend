using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IReportReasonRepository
	{
		Task<IEnumerable<ReportReasons>> GetReportReasons(ReportReasonParameters reportReasonParameters, bool trackChange, CancellationToken ct = default);
		Task<ReportReasons?> GetReportReasonById(Guid id, bool trackChange, CancellationToken ct = default);
		void CreateReportReason(ReportReasons reportReason);
		void DeleteReportReason(ReportReasons reportReason);
	}
}
