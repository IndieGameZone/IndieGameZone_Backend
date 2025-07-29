using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Infrastructure.Extensions;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Infrastructure.Repositories
{
	internal sealed class ReportRepository : RepositoryBase<Reports>, IReportRepository
	{
		public ReportRepository(AppDbContext appDbContext) : base(appDbContext)
		{
		}

		public void CreateReport(Reports report) => Create(report);

		public async Task<Reports?> GetReportById(Guid id, bool trackChange, CancellationToken ct = default)
		{
			return await FindByCondition(r => r.Id.Equals(id), trackChange)
				.Include(r => r.ReportingUser).AsSplitQuery()
				.Include(r => r.ReportReason).AsSplitQuery()
				.Include(r => r.Post).AsSplitQuery()
				.Include(r => r.Game).AsSplitQuery()
				.Include(r => r.PostComment).AsSplitQuery()
				.FirstOrDefaultAsync(ct);
		}

		public async Task<PagedList<Reports>> GetReports(ReportParameters reportParameters, bool trackChange, CancellationToken ct = default)
		{
			var reports = FindAll(trackChange)
				.Include(r => r.ReportingUser).AsSplitQuery()
				.Include(r => r.ReportReason).AsSplitQuery()
				.Include(r => r.Post).AsSplitQuery()
				.Include(r => r.Game).AsSplitQuery()
				.Include(r => r.PostComment).AsSplitQuery()
				.Sort();

			return await PagedList<Reports>.ToPagedList(reports, reportParameters.PageNumber, reportParameters.PageSize, ct);
		}

		public Task<PagedList<Reports>> GetReportsByReportedUserId(Guid reportedUserId, ReportParameters reportParameters, bool trackChange, CancellationToken ct = default)
		{
			var reports = FindAll(trackChange)
				.Include(r => r.ReportingUser).AsSplitQuery()
				.Include(r => r.ReportReason).AsSplitQuery()
				.Include(r => r.Post).AsSplitQuery()
				.Include(r => r.Game).AsSplitQuery()
				.Include(r => r.PostComment).AsSplitQuery()
				.Where(r =>
					(r.Post != null && r.Post.UserId == reportedUserId) ||
					(r.PostComment != null && r.PostComment.UserId == reportedUserId) ||
					(r.Game != null && r.Game.DeveloperId == reportedUserId)
				)
				.Sort();

			return PagedList<Reports>.ToPagedList(reports, reportParameters.PageNumber, reportParameters.PageSize, ct);
		}

		public Task<PagedList<Reports>> GetReportsByReportingUserId(Guid reportingUserId, ReportParameters reportParameters, bool trackChange, CancellationToken ct = default)
		{
			var reports = FindByCondition(r => r.ReportingUserId.Equals(reportingUserId), trackChange)
				.Include(r => r.ReportingUser).AsSplitQuery()
				.Include(r => r.ReportReason).AsSplitQuery()
				.Include(r => r.Post).AsSplitQuery()
				.Include(r => r.Game).AsSplitQuery()
				.Include(r => r.PostComment).AsSplitQuery()
				.Sort();

			return PagedList<Reports>.ToPagedList(reports, reportParameters.PageNumber, reportParameters.PageSize, ct);
		}
	}
}
