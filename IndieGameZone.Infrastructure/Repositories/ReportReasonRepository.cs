using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
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
			FindByCondition(x => x.Id.Equals(id) && x.IsDeleted, trackChange).FirstOrDefaultAsync(ct);

		public async Task<IEnumerable<ReportReasons>> GetReportReasons(ReportReasonParameters reportReasonParameters, bool trackChange, CancellationToken ct = default)
		{
			return await FindByCondition(x => !x.IsDeleted, trackChange)
				.FilterByType(reportReasonParameters.ReportReasonType)
				.Sort()
				.ToListAsync(ct);
		}
	}
}
