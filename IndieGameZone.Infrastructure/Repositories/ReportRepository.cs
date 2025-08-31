using IndieGameZone.Domain.Constants;
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
                .Include(r => r.ReportingUser).ThenInclude(ru => ru.UserProfile).AsSplitQuery()
                .Include(r => r.ReportReason).AsSplitQuery()
                .Include(r => r.Post).ThenInclude(p => p.PostComments).AsSplitQuery()
                .Include(r => r.Post).ThenInclude(p => p.User).ThenInclude(u => u.UserProfile).AsSplitQuery()
                .Include(r => r.Post).ThenInclude(p => p.Game).ThenInclude(u => u.Developer).AsSplitQuery()
                .Include(r => r.Post).ThenInclude(p => p.Game).ThenInclude(u => u.Reviews).AsSplitQuery()
                .Include(r => r.Post).ThenInclude(p => p.Game).ThenInclude(u => u.Discounts).AsSplitQuery()
                .Include(r => r.Post).ThenInclude(p => p.Game).ThenInclude(u => u.Category).AsSplitQuery()
                .Include(r => r.Post).ThenInclude(p => p.Game).ThenInclude(u => u.GameTags).ThenInclude(gt => gt.Tag).AsSplitQuery()
                .Include(r => r.PostComment).ThenInclude(pc => pc.User).ThenInclude(u => u.UserProfile).AsSplitQuery()
                .Include(r => r.Game).ThenInclude(g => g.Developer).ThenInclude(u => u.UserProfile).AsSplitQuery()
                .Include(r => r.Game).ThenInclude(g => g.Discounts).AsSplitQuery()
                .Include(r => r.Game).ThenInclude(g => g.Category).AsSplitQuery()
                .Include(r => r.Game).ThenInclude(g => g.GameTags).ThenInclude(gt => gt.Tag).AsSplitQuery()
                .Include(r => r.Review).ThenInclude(rv => rv.User).ThenInclude(u => u.UserProfile).AsSplitQuery()
                .FirstOrDefaultAsync(ct);
        }

        public async Task<PagedList<Reports>> GetReports(
    ReportParameters reportParameters, bool trackChange, CancellationToken ct = default)
        {
            IQueryable<Reports> query = FindAll(trackChange);

            switch (reportParameters.ReportType)
            {
                case ReportReasonTypeEnum.Game:
                    query = query
                        .Where(r => r.ReportReason.Type == ReportReasonTypeEnum.Game)
                        .Include(r => r.ReportingUser).ThenInclude(u => u.UserProfile)
                        .Include(r => r.ReportReason)
                        .Include(r => r.Game).ThenInclude(g => g.Developer).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.Reviews).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.Discounts).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.Category).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.GameTags).ThenInclude(gt => gt.Tag).AsSplitQuery();
                    break;

                case ReportReasonTypeEnum.Post:
                    query = query
                        .Where(r => r.ReportReason.Type == ReportReasonTypeEnum.Post)
                        .Include(r => r.ReportingUser).ThenInclude(u => u.UserProfile)
                        .Include(r => r.ReportReason)
                        .Include(r => r.Post).ThenInclude(p => p.PostComments).AsSplitQuery()
                        .Include(r => r.Post).ThenInclude(p => p.User).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.Post).ThenInclude(p => p.Game).ThenInclude(u => u.Developer).AsSplitQuery()
                        .Include(r => r.Post).ThenInclude(p => p.Game).ThenInclude(u => u.Reviews).AsSplitQuery()
                        .Include(r => r.Post).ThenInclude(p => p.Game).ThenInclude(u => u.Discounts).AsSplitQuery()
                        .Include(r => r.Post).ThenInclude(p => p.Game).ThenInclude(u => u.Category).AsSplitQuery()
                        .Include(r => r.Post).ThenInclude(p => p.Game).ThenInclude(u => u.GameTags).ThenInclude(gt => gt.Tag).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.Developer).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.Reviews).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.Discounts).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.Category).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.GameTags).ThenInclude(gt => gt.Tag).AsSplitQuery();
                    break;

                case ReportReasonTypeEnum.Comment:
                    query = query
                        .Where(r => r.ReportReason.Type == ReportReasonTypeEnum.Comment)
                        .Include(r => r.ReportingUser).ThenInclude(u => u.UserProfile)
                        .Include(r => r.ReportReason)
                        .Include(r => r.Post).ThenInclude(p => p.PostComments).AsSplitQuery()
                        .Include(r => r.Post).ThenInclude(p => p.User).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.Post).ThenInclude(p => p.Game).ThenInclude(u => u.Developer).AsSplitQuery()
                        .Include(r => r.Post).ThenInclude(p => p.Game).ThenInclude(u => u.Reviews).AsSplitQuery()
                        .Include(r => r.Post).ThenInclude(p => p.Game).ThenInclude(u => u.Discounts).AsSplitQuery()
                        .Include(r => r.Post).ThenInclude(p => p.Game).ThenInclude(u => u.Category).AsSplitQuery()
                        .Include(r => r.Post).ThenInclude(p => p.Game).ThenInclude(u => u.GameTags).ThenInclude(gt => gt.Tag).AsSplitQuery()
                        .Include(r => r.PostComment).ThenInclude(pc => pc.User).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.Developer).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.Reviews).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.Discounts).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.Category).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.GameTags).ThenInclude(gt => gt.Tag).AsSplitQuery();
                    break;

                case ReportReasonTypeEnum.Review:
                    query = query
                        .Where(r => r.ReportReason.Type == ReportReasonTypeEnum.Review)
                        .Include(r => r.ReportingUser).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.ReportReason).AsSplitQuery()
                        .Include(r => r.Review).ThenInclude(rv => rv.User).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.Review.Game).ThenInclude(g => g.Developer).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.Review.Game).ThenInclude(g => g.Discounts).AsSplitQuery()
                        .Include(r => r.Review.Game).ThenInclude(g => g.Category).AsSplitQuery()
                        .Include(r => r.Review.Game).ThenInclude(g => g.GameTags).ThenInclude(gt => gt.Tag).AsSplitQuery();
                    break;

                default:
                    // fallback – minimal data
                    query = query
                        .Where(r => r.ReportReason.Type == reportParameters.ReportType)
                        .Include(r => r.ReportingUser).ThenInclude(u => u.UserProfile)
                        .Include(r => r.ReportReason);
                    break;
            }

            query = query.Sort();

            return await PagedList<Reports>.ToPagedList(
                query,
                reportParameters.PageNumber,
                reportParameters.PageSize,
                ct
            );
        }

        public async Task<PagedList<Reports>> GetReportsByReportedUserId(
    Guid reportedUserId,
    ReportParameters reportParameters,
    bool trackChange,
    CancellationToken ct = default)
        {
            IQueryable<Reports> query = FindAll(trackChange);

            switch (reportParameters.ReportType)
            {
                case ReportReasonTypeEnum.Game:
                    query = query
                        .Include(r => r.ReportingUser).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.ReportReason).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.Developer).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.Reviews).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.Discounts).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.Category).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.GameTags).ThenInclude(gt => gt.Tag).AsSplitQuery()
                        .Where(r => r.Game != null && r.Game.DeveloperId == reportedUserId);
                    break;

                case ReportReasonTypeEnum.Post:
                    query = query
                        .Include(r => r.ReportingUser).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.ReportReason).AsSplitQuery()
                        .Include(r => r.Post).ThenInclude(p => p.PostComments).AsSplitQuery()
                        .Include(r => r.Post).ThenInclude(p => p.User).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.Post).ThenInclude(p => p.Game).ThenInclude(g => g.Developer).AsSplitQuery()
                        .Where(r => r.Post != null && r.Post.UserId == reportedUserId);
                    break;

                case ReportReasonTypeEnum.Comment:
                    query = query
                        .Include(r => r.ReportingUser).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.ReportReason).AsSplitQuery()
                        .Include(r => r.PostComment).ThenInclude(pc => pc.User).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.Post).ThenInclude(p => p.Game).ThenInclude(g => g.Developer).AsSplitQuery()
                        .Where(r => r.PostComment != null && r.PostComment.UserId == reportedUserId);
                    break;

                case ReportReasonTypeEnum.Review:
                    query = query
                        .Include(r => r.ReportingUser).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.ReportReason).AsSplitQuery()
                        .Include(r => r.Review).ThenInclude(rv => rv.User).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.Developer).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.Discounts).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.Category).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.GameTags).ThenInclude(gt => gt.Tag).AsSplitQuery()
                        .Where(r => r.Review != null && r.Review.UserId == reportedUserId);
                    break;

                default:
                    query = query
                        .Include(r => r.ReportingUser).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.ReportReason).AsSplitQuery();
                    break;
            }

            query = query.Sort();

            return await PagedList<Reports>.ToPagedList(
                query,
                reportParameters.PageNumber,
                reportParameters.PageSize,
                ct
            );
        }

        public async Task<PagedList<Reports>> GetReportsByReportingUserId(
    Guid reportingUserId,
    ReportParameters reportParameters,
    bool trackChange,
    CancellationToken ct = default)
        {
            IQueryable<Reports> query = FindByCondition(r => r.ReportingUserId == reportingUserId, trackChange);

            switch (reportParameters.ReportType)
            {
                case ReportReasonTypeEnum.Game:
                    query = query
                        .Include(r => r.ReportingUser).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.ReportReason).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.Developer).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.Reviews).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.Discounts).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.Category).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.GameTags).ThenInclude(gt => gt.Tag).AsSplitQuery()
                        .Where(r => r.Game != null);
                    break;

                case ReportReasonTypeEnum.Post:
                    query = query
                        .Include(r => r.ReportingUser).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.ReportReason).AsSplitQuery()
                        .Include(r => r.Post).ThenInclude(p => p.PostComments).AsSplitQuery()
                        .Include(r => r.Post).ThenInclude(p => p.User).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.Post).ThenInclude(p => p.Game).ThenInclude(g => g.Developer).AsSplitQuery()
                        .Include(r => r.Post).ThenInclude(p => p.Game).ThenInclude(g => g.Reviews).AsSplitQuery()
                        .Include(r => r.Post).ThenInclude(p => p.Game).ThenInclude(g => g.Discounts).AsSplitQuery()
                        .Include(r => r.Post).ThenInclude(p => p.Game).ThenInclude(g => g.Category).AsSplitQuery()
                        .Include(r => r.Post).ThenInclude(p => p.Game).ThenInclude(g => g.GameTags).ThenInclude(gt => gt.Tag).AsSplitQuery()
                        .Where(r => r.Post != null);
                    break;

                case ReportReasonTypeEnum.Comment:
                    query = query
                        .Include(r => r.ReportingUser).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.ReportReason).AsSplitQuery()
                        .Include(r => r.PostComment).ThenInclude(pc => pc.User).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.Post).ThenInclude(p => p.Game).ThenInclude(g => g.Developer).AsSplitQuery()
                        .Where(r => r.PostComment != null);
                    break;

                case ReportReasonTypeEnum.Review:
                    query = query
                        .Include(r => r.ReportingUser).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.ReportReason).AsSplitQuery()
                        .Include(r => r.Review).ThenInclude(rv => rv.User).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.Developer).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.Discounts).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.Category).AsSplitQuery()
                        .Include(r => r.Game).ThenInclude(g => g.GameTags).ThenInclude(gt => gt.Tag).AsSplitQuery()
                        .Where(r => r.Review != null);
                    break;

                default:
                    query = query
                        .Include(r => r.ReportingUser).ThenInclude(u => u.UserProfile).AsSplitQuery()
                        .Include(r => r.ReportReason).AsSplitQuery();
                    break;
            }

            query = query.Sort();

            return await PagedList<Reports>.ToPagedList(
                query,
                reportParameters.PageNumber,
                reportParameters.PageSize,
                ct
            );
        }
    }
}

