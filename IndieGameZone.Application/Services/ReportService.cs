using IndieGameZone.Application.Hub;
using IndieGameZone.Application.IHub;
using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Reports;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Notifications;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Reports;
using MapsterMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Application.Services
{
	internal sealed class ReportService : IReportService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly IHubContext<NotificationHub, INotificationHub> notificationHub;
		private readonly UserManager<Users> userManager;

		public ReportService(IRepositoryManager repositoryManager, IMapper mapper, IHubContext<NotificationHub, INotificationHub> notificationHub, UserManager<Users> userManager)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.notificationHub = notificationHub;
			this.userManager = userManager;
		}

		public async Task CreateCommentReport(Guid reportingUserId, ReportCommentForCreationDto reportForCreationDto, CancellationToken ct = default)
		{
			var comment = await repositoryManager.PostCommentRepository.GetCommentById(reportForCreationDto.CommentId, false, ct);
			if (comment == null) throw new NotFoundException("Comment not found");

			var user = await userManager.Users.AsNoTracking().SingleOrDefaultAsync(u => u.Id == reportingUserId);
			if (user == null) throw new NotFoundException("User not found");

			var reportEntity = mapper.Map<Reports>(reportForCreationDto);
			reportEntity.ReportingUserId = reportingUserId;
			reportEntity.Id = Guid.NewGuid();
			reportEntity.CreatedAt = DateTime.Now;

			repositoryManager.ReportRepository.CreateReport(reportEntity);

			var notification = new Notifications
			{
				Id = Guid.NewGuid(),
				UserId = comment.UserId,
				Message = "Your comment has been reported",
				CreatedAt = DateTime.Now,
				IsRead = false
			};
			repositoryManager.NotificationRepository.CreateNotification(notification);
			await notificationHub.Clients.User(comment.UserId.ToString()).SendNotification(new NotificationForReturnDto
			{
				Id = notification.Id,
				Message = notification.Message,
				CreatedAt = notification.CreatedAt,
				IsRead = notification.IsRead,
				ReadAt = notification.ReadAt
			});
			await repositoryManager.SaveAsync(ct);
		}

		public async Task CreateGameReport(Guid reportingUserId, ReportGameForCreationDto reportForCreationDto, CancellationToken ct = default)
		{
			var game = await repositoryManager.GameRepository.GetGameById(reportForCreationDto.GameId, false, ct);
			if (game == null) throw new NotFoundException("Game not found");

			var user = await userManager.Users.AsNoTracking().SingleOrDefaultAsync(u => u.Id == reportingUserId);
			if (user == null) throw new NotFoundException("User not found");

			var reportEntity = mapper.Map<Reports>(reportForCreationDto);
			reportEntity.ReportingUserId = reportingUserId;
			reportEntity.Id = Guid.NewGuid();
			reportEntity.CreatedAt = DateTime.Now;

			repositoryManager.ReportRepository.CreateReport(reportEntity);

			var notification = new Notifications
			{
				Id = Guid.NewGuid(),
				UserId = game.DeveloperId,
				Message = "Your game has been reported",
				CreatedAt = DateTime.Now,
				IsRead = false
			};
			repositoryManager.NotificationRepository.CreateNotification(notification);
			await notificationHub.Clients.User(game.DeveloperId.ToString()).SendNotification(new NotificationForReturnDto
			{
				Id = notification.Id,
				Message = notification.Message,
				CreatedAt = notification.CreatedAt,
				IsRead = notification.IsRead,
				ReadAt = notification.ReadAt
			});
			await repositoryManager.SaveAsync(ct);
		}

		public async Task CreatePostReport(Guid reportingUserId, ReportPostForCreationDto reportForCreationDto, CancellationToken ct = default)
		{
			var post = await repositoryManager.PostRepository.GetPostById(reportForCreationDto.PostId, false, ct);
			if (post == null) throw new NotFoundException("Post not found");

			var user = await userManager.Users.AsNoTracking().SingleOrDefaultAsync(u => u.Id == reportingUserId);
			if (user == null) throw new NotFoundException("User not found");

			var reportEntity = mapper.Map<Reports>(reportForCreationDto);
			reportEntity.ReportingUserId = reportingUserId;
			reportEntity.Id = Guid.NewGuid();
			reportEntity.CreatedAt = DateTime.Now;

			repositoryManager.ReportRepository.CreateReport(reportEntity);

			var notification = new Notifications
			{
				Id = Guid.NewGuid(),
				UserId = post.UserId,
				Message = "Your comment has been reported",
				CreatedAt = DateTime.Now,
				IsRead = false
			};
			repositoryManager.NotificationRepository.CreateNotification(notification);
			await notificationHub.Clients.User(post.UserId.ToString()).SendNotification(new NotificationForReturnDto
			{
				Id = notification.Id,
				Message = notification.Message,
				CreatedAt = notification.CreatedAt,
				IsRead = notification.IsRead,
				ReadAt = notification.ReadAt
			});
			await repositoryManager.SaveAsync(ct);
		}

        public async Task CreateReviewReport(Guid reportingUserId, ReportReviewForCreationDto reportForCreationDto, CancellationToken ct = default)
        {
            // 1. Validate that the review exists
            var review = await repositoryManager.ReviewRepository.GetReviewById(reportForCreationDto.ReviewId, false, ct);
            if (review == null) throw new NotFoundException("Review not found");

            // 2. Validate that the reporting user exists
            var user = await userManager.Users.AsNoTracking().SingleOrDefaultAsync(u => u.Id == reportingUserId, ct);
            if (user == null) throw new NotFoundException("User not found");

            // 3. Map and create report entity
            var reportEntity = mapper.Map<Reports>(reportForCreationDto);
            reportEntity.ReportingUserId = reportingUserId;
            reportEntity.Id = Guid.NewGuid();
            reportEntity.CreatedAt = DateTime.Now;

            repositoryManager.ReportRepository.CreateReport(reportEntity);

            // 4. Notify the review owner
            var notification = new Notifications
            {
                Id = Guid.NewGuid(),
                UserId = review.UserId,
                Message = "Your review has been reported",
                CreatedAt = DateTime.Now,
                IsRead = false
            };
            repositoryManager.NotificationRepository.CreateNotification(notification);

            await notificationHub.Clients.User(review.UserId.ToString()).SendNotification(new NotificationForReturnDto
            {
                Id = notification.Id,
                Message = notification.Message,
                CreatedAt = notification.CreatedAt,
                IsRead = notification.IsRead,
                ReadAt = notification.ReadAt
            });

            // 5. Save changes
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
                ReportReasonTypeEnum.Review => mapper.Map<ReviewReportForReturnDto>(report),
                _ => mapper.Map<ReportForReturnDto>(report)
			};
		}

        public async Task<(IEnumerable<object> reports, MetaData metaData)> GetReports(
    ReportParameters reportParameters,
    CancellationToken ct = default)
        {
            var reportsWithMeta = await repositoryManager.ReportRepository
                .GetReports(reportParameters, false, ct);

            IEnumerable<object> mapped = reportParameters.ReportType switch
            {
                ReportReasonTypeEnum.Game =>
                    reportsWithMeta.Select(r => mapper.Map<GameReportForReturnDto>(r)),

                ReportReasonTypeEnum.Post =>
                    reportsWithMeta.Select(r => mapper.Map<PostReportForReturnDto>(r)),

                ReportReasonTypeEnum.Comment =>
                    reportsWithMeta.Select(r => mapper.Map<CommentReportForReturnDto>(r)),

                ReportReasonTypeEnum.Review =>
                    reportsWithMeta.Select(r => mapper.Map<ReviewReportForReturnDto>(r)),

                _ => reportsWithMeta.Select(r => mapper.Map<ReportForReturnDto>(r))
            };

            return (mapped, reportsWithMeta.MetaData);
        }
        public async Task<(IEnumerable<object> reports, MetaData metaData)> GetReportsByReportedUserId(
    Guid reportedUserId,
    ReportParameters reportParameters,
    CancellationToken ct = default)
        {
            // 1. Validate that reported user exists
            var user = await userManager.Users
                .AsNoTracking()
                .SingleOrDefaultAsync(u => u.Id == reportedUserId, ct);

            if (user == null)
                throw new NotFoundException("User not found");

            // 2. Query reports from repository
            var reportsWithMeta = await repositoryManager.ReportRepository
                .GetReportsByReportedUserId(reportedUserId, reportParameters, false, ct);

            // 3. Map dynamically depending on report type
            var mapped = reportsWithMeta.Select(report => report.ReportReason.Type switch
            {
                ReportReasonTypeEnum.Game => (object)mapper.Map<GameReportForReturnDto>(report),
                ReportReasonTypeEnum.Post => mapper.Map<PostReportForReturnDto>(report),
                ReportReasonTypeEnum.Comment => mapper.Map<CommentReportForReturnDto>(report),
                ReportReasonTypeEnum.Review => mapper.Map<ReviewReportForReturnDto>(report),
                _ => mapper.Map<ReportForReturnDto>(report)
            });

            // 4. Return mapped + metaData
            return (mapped, reportsWithMeta.MetaData);
        }

        public async Task<(IEnumerable<object> reports, MetaData metaData)> GetReportsByReportingUserId(
    Guid reportingUserId,
    ReportParameters reportParameters,
    CancellationToken ct = default)
        {
            var user = await userManager.Users
                .AsNoTracking()
                .SingleOrDefaultAsync(u => u.Id == reportingUserId, ct);

            if (user == null)
                throw new NotFoundException("User not found");

            var reportsWithMeta = await repositoryManager.ReportRepository
                .GetReportsByReportingUserId(reportingUserId, reportParameters, false, ct);

            var mappedReports = reportsWithMeta.Select(report => report.ReportReason.Type switch
            {
                ReportReasonTypeEnum.Game => (object)mapper.Map<GameReportForReturnDto>(report),
                ReportReasonTypeEnum.Post => mapper.Map<PostReportForReturnDto>(report),
                ReportReasonTypeEnum.Comment => mapper.Map<CommentReportForReturnDto>(report),
                ReportReasonTypeEnum.Review => mapper.Map<ReviewReportForReturnDto>(report),
                _ => mapper.Map<ReportForReturnDto>(report)
            });

            return (mappedReports, reportsWithMeta.MetaData);
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

			var notification = new Notifications
			{
				Id = Guid.NewGuid(),
				UserId = reportEntity.ReportingUserId,
				Message = $"Your report about {reportEntity.Message} has been {reportEntity.Status} - {reportEntity.ReviewMessage}",
				CreatedAt = DateTime.Now,
				IsRead = false
			};
			repositoryManager.NotificationRepository.CreateNotification(notification);
			await notificationHub.Clients.User(reportEntity.ReportingUserId.ToString()).SendNotification(new NotificationForReturnDto
			{
				Id = notification.Id,
				Message = notification.Message,
				CreatedAt = notification.CreatedAt,
				IsRead = notification.IsRead,
				ReadAt = notification.ReadAt
			});

			await repositoryManager.SaveAsync(ct);
		}
	}
}
