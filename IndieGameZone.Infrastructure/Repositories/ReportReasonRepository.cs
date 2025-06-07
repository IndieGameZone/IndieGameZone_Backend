using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class ReportReasonRepository : RepositoryBase<ReportReasons>, IReportReasonRepository
	{
		public ReportReasonRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateReportReason(ReportReasons reportReason) => Create(reportReason);

		public void DeleteReportReason(ReportReasons reportReason) => Delete(reportReason);

		public async Task<ReportReasons?> GetReportReasonById(Guid id, bool trackChange, CancellationToken ct = default) => await
			FindByCondition(x => x.Id.Equals(id), trackChange).FirstOrDefaultAsync(ct);

		public async Task<IEnumerable<ReportReasons>> GetReportReasons(bool trackChange, CancellationToken ct = default)
		{
			return await FindAll(trackChange)
				.Sort()
				.ToListAsync(ct);
		}
	}
}
