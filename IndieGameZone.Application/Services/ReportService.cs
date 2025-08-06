using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Reports;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Reports;
using MapsterMapper;

namespace IndieGameZone.Application.Services
{
	internal sealed class ReportService : IReportService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public ReportService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}

		public async Task CreateCommentReport(Guid reportingUserId, ReportCommentForCreationDto reportForCreationDto, CancellationToken ct = default)
		{
			var reportEntity = mapper.Map<Reports>(reportForCreationDto);
			reportEntity.ReportingUserId = reportingUserId;
			reportEntity.Id = Guid.NewGuid();
			reportEntity.CreatedAt = DateTime.Now;

			repositoryManager.ReportRepository.CreateReport(reportEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task CreateGameReport(Guid reportingUserId, ReportGameForCreationDto reportForCreationDto, CancellationToken ct = default)
		{
			var reportEntity = mapper.Map<Reports>(reportForCreationDto);
			reportEntity.ReportingUserId = reportingUserId;
			reportEntity.Id = Guid.NewGuid();
			reportEntity.CreatedAt = DateTime.Now;

			repositoryManager.ReportRepository.CreateReport(reportEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task CreatePostReport(Guid reportingUserId, ReportPostForCreationDto reportForCreationDto, CancellationToken ct = default)
		{
			var reportEntity = mapper.Map<Reports>(reportForCreationDto);
			reportEntity.ReportingUserId = reportingUserId;
			reportEntity.Id = Guid.NewGuid();
			reportEntity.CreatedAt = DateTime.Now;

			repositoryManager.ReportRepository.CreateReport(reportEntity);
			await repositoryManager.SaveAsync(ct);
		}

        public async Task<object> GetReportById(Guid id, CancellationToken ct = default)
        {
            var report = await repositoryManager.ReportRepository.GetReportById(id, false, ct);
            if (report == null)
                throw new NotFoundException("Report not found.");

            return report.ReportReason.Type switch
            {
                ReportReasonTypeEnum.Game => mapper.Map<GameReportForReturnDto>(report),
                ReportReasonTypeEnum.Post => mapper.Map<PostReportForReturnDto>(report),
                ReportReasonTypeEnum.Comment => mapper.Map<CommentReportForReturnDto>(report),
                _ => mapper.Map<ReportForReturnDto>(report)
            };
        }

        public async Task<(IEnumerable<object> reports, MetaData metaData)> GetReports(ReportParameters reportParameters, CancellationToken ct = default)
        {
            var reportsWithMeta = await repositoryManager.ReportRepository.GetReports(reportParameters, false, ct);
            var mapped = reportsWithMeta.Select(report => report.ReportReason.Type switch
            {
                ReportReasonTypeEnum.Game => (object)mapper.Map<GameReportForReturnDto>(report),
                ReportReasonTypeEnum.Post => mapper.Map<PostReportForReturnDto>(report),
                ReportReasonTypeEnum.Comment => mapper.Map<CommentReportForReturnDto>(report),
                _ => mapper.Map<ReportForReturnDto>(report)
            });

            return (mapped, reportsWithMeta.MetaData);
        }

        public async Task<(IEnumerable<object> reports, MetaData metaData)> GetReportsByReportedUserId(Guid reportedUserId, ReportParameters reportParameters, CancellationToken ct = default)
        {
            var reportsWithMeta = await repositoryManager.ReportRepository.GetReportsByReportedUserId(reportedUserId, reportParameters, false, ct);
            var mapped = reportsWithMeta.Select(report => report.ReportReason.Type switch
            {
                ReportReasonTypeEnum.Game => (object)mapper.Map<GameReportForReturnDto>(report),
                ReportReasonTypeEnum.Post => mapper.Map<PostReportForReturnDto>(report),
                ReportReasonTypeEnum.Comment => mapper.Map<CommentReportForReturnDto>(report),
                _ => mapper.Map<ReportForReturnDto>(report)
            });

            return (mapped, reportsWithMeta.MetaData);
        }

        public async Task<(IEnumerable<object> reports, MetaData metaData)> GetReportsByReportingUserId(Guid reportingUserId, ReportParameters reportParameters, CancellationToken ct = default)
        {
            var reportsWithMeta = await repositoryManager.ReportRepository.GetReportsByReportingUserId(reportingUserId, reportParameters, false, ct);
            var mapped = reportsWithMeta.Select(report => report.ReportReason.Type switch
            {
                ReportReasonTypeEnum.Game => (object)mapper.Map<GameReportForReturnDto>(report),
                ReportReasonTypeEnum.Post => mapper.Map<PostReportForReturnDto>(report),
                ReportReasonTypeEnum.Comment => mapper.Map<CommentReportForReturnDto>(report),
                _ => mapper.Map<ReportForReturnDto>(report)
            });

            return (mapped, reportsWithMeta.MetaData);
        }

        public async Task UpdateResolveStatus(Guid id, ReportStatus updatedStatus, ReportForUpdateStatusDto? dto, CancellationToken ct = default)
		{
			var reportEntity = await repositoryManager.ReportRepository.GetReportById(id, true, ct);
			if (reportEntity == null)
			{
				throw new NotFoundException($"Report not found.");
			}
			reportEntity.Status = updatedStatus;
            reportEntity.ReviewMessage = dto.ReviewMessage;
			reportEntity.UpdatedAt = DateTime.Now;

            repositoryManager.NotificationRepository.CreateNotification(new Notifications
			{
				Id = Guid.NewGuid(),
				UserId = reportEntity.ReportingUserId,
				Message = $"Your report about {reportEntity.Message} has been {reportEntity.Status} - {reportEntity.ReviewMessage}",
				CreatedAt = DateTime.Now,
				IsRead = false
			});

			await repositoryManager.SaveAsync(ct);
		}
	}
}
