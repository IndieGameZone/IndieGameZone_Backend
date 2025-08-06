using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestFeatures;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IReportRepository
	{
		void CreateReport(Reports report);
		Task<Reports?> GetReportById(Guid id, bool trackChange, CancellationToken ct = default);
		Task<PagedList<Reports>> GetReports(ReportParameters reportParameters, bool trackChange, CancellationToken ct = default);
        Task<PagedList<Reports>> GetReportsByReportingUserId(Guid reportingUserId, ReportParameters reportParameters, bool trackChange, CancellationToken ct = default);
		Task<PagedList<Reports>> GetReportsByReportedUserId(Guid reportedUserId, ReportParameters reportParameters, bool trackChange, CancellationToken ct = default);
	}
}
