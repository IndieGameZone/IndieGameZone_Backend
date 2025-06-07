using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IReportReasonRepository
	{
		Task<IEnumerable<ReportReasons>> GetReportReasons(bool trackChange, CancellationToken ct = default);
		Task<ReportReasons?> GetReportReasonById(Guid id, bool trackChange, CancellationToken ct = default);
		void CreateReportReason(ReportReasons reportReason);
		void DeleteReportReason(ReportReasons reportReason);
	}
}
