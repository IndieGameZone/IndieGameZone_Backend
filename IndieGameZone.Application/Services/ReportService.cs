using IndieGameZone.Application.IServices;
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

		public async Task<ReportForReturnDto> GetReportById(Guid id, CancellationToken ct = default)
		{
			var reportEntity = await repositoryManager.ReportRepository.GetReportById(id, false, ct);
			if (reportEntity == null)
			{
				throw new NotFoundException($"Report not found.");
			}
			return mapper.Map<ReportForReturnDto>(reportEntity);
		}

		public async Task<(IEnumerable<ReportForReturnDto> reports, MetaData metaData)> GetReports(ReportParameters reportParameters, CancellationToken ct = default)
		{
			var reportsWithMetaData = await repositoryManager.ReportRepository.GetReports(reportParameters, false, ct);
			var reports = mapper.Map<IEnumerable<ReportForReturnDto>>(reportsWithMetaData);
			return (reports, reportsWithMetaData.MetaData);
		}

		public async Task<(IEnumerable<ReportForReturnDto> reports, MetaData metaData)> GetReportsByReportedUserId(Guid reportedUserId, ReportParameters reportParameters, CancellationToken ct = default)
		{
			var reportsWithMetaData = await repositoryManager.ReportRepository.GetReportsByReportedUserId(reportedUserId, reportParameters, false, ct);
			var reports = mapper.Map<IEnumerable<ReportForReturnDto>>(reportsWithMetaData);
			return (reports, reportsWithMetaData.MetaData);
		}

		public async Task<(IEnumerable<ReportForReturnDto> reports, MetaData metaData)> GetReportsByReportingUserId(Guid reportingUserId, ReportParameters reportParameters, CancellationToken ct = default)
		{
			var reportsWithMetaData = await repositoryManager.ReportRepository.GetReportsByReportingUserId(reportingUserId, reportParameters, false, ct);
			var reports = mapper.Map<IEnumerable<ReportForReturnDto>>(reportsWithMetaData);
			return (reports, reportsWithMetaData.MetaData);
		}

		public async Task UpdateResolveStatus(Guid id, CancellationToken ct = default)
		{
			var reportEntity = await repositoryManager.ReportRepository.GetReportById(id, true, ct);
			if (reportEntity == null)
			{
				throw new NotFoundException($"Report not found.");
			}
			reportEntity.IsResolved = true;

			repositoryManager.NotificationRepository.CreateNotification(new Notifications
			{
				Id = Guid.NewGuid(),
				UserId = reportEntity.ReportingUserId,
				Message = $"Your report has been resolved - {reportEntity.Message}",
				CreatedAt = DateTime.Now,
				IsRead = false
			});

			await repositoryManager.SaveAsync(ct);
		}
	}
}
