using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestsAndResponses.Requests.ReportReasons;
using IndieGameZone.Domain.RequestsAndResponses.Responses.ReportReasons;
using MapsterMapper;

namespace IndieGameZone.Application.Services
{
	internal sealed class ReportReasonService : IReportReasonService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		public ReportReasonService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}
		public async Task<IEnumerable<ReportReasonForReturnDto>> GetReportReasons(CancellationToken ct = default)
		{
			var reportReasons = await repositoryManager.ReportReasonRepository.GetReportReasons(false, ct);
			return mapper.Map<IEnumerable<ReportReasonForReturnDto>>(reportReasons);
		}
		public async Task<ReportReasonForReturnDto?> GetReportReasonById(Guid id, CancellationToken ct = default)
		{
			var reportReasonEntity = await repositoryManager.ReportReasonRepository.GetReportReasonById(id, false, ct);
			if (reportReasonEntity is null)
			{
				throw new NotFoundException($"Report reason not found.");
			}
			return mapper.Map<ReportReasonForReturnDto>(reportReasonEntity);
		}
		public async Task CreateReportReason(ReportReasonForCreationDto reportReasonDto, CancellationToken ct = default)
		{
			var reportReasonEntity = mapper.Map<Domain.Entities.ReportReasons>(reportReasonDto);
			reportReasonEntity.Id = Guid.NewGuid();
			repositoryManager.ReportReasonRepository.CreateReportReason(reportReasonEntity);
			await repositoryManager.SaveAsync(ct);
		}
		public async Task UpdateReportReason(Guid id, ReportReasonForUpdateDto reportReasonDto, CancellationToken ct = default)
		{
			var reportReasonEntity = await repositoryManager.ReportReasonRepository.GetReportReasonById(id, true, ct);
			if (reportReasonEntity is null)
			{
				throw new NotFoundException($"Report reason with ID {id} not found.");
			}
			mapper.Map(reportReasonDto, reportReasonEntity);
			await repositoryManager.SaveAsync(ct);
		}
		public async Task DeleteReportReason(Guid id, CancellationToken ct = default)
		{
			var reportReasonEntity = await repositoryManager.ReportReasonRepository.GetReportReasonById(id, false, ct);
			if (reportReasonEntity is null)
			{
				throw new NotFoundException($"Report reason not found.");
			}
			repositoryManager.ReportReasonRepository.DeleteReportReason(reportReasonEntity);
			await repositoryManager.SaveAsync(ct);
		}
	}
}
