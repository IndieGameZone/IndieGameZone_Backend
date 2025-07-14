using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Platforms;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Platforms;
using MapsterMapper;

namespace IndieGameZone.Application.Services
{
	internal sealed class PlatformService : IPlatformService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public PlatformService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}

		public async Task CreatePlatform(PlatformForCreationDto platformForCreationDto, CancellationToken ct = default)
		{
			var platformEntity = mapper.Map<Domain.Entities.Platforms>(platformForCreationDto);
			platformEntity.Id = Guid.NewGuid();
			repositoryManager.PlatformRepository.CreatePlatform(platformEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task DeletePlatform(Guid id, CancellationToken ct = default)
		{
			var platformEntity = await repositoryManager.PlatformRepository.GetPlatformById(id, false, ct);
			if (platformEntity is null)
			{
				throw new NotFoundException($"Platform not found.");
			}
			repositoryManager.PlatformRepository.DeletePlatform(platformEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task<PlatformForReturnDto> GetPlatformById(Guid id, CancellationToken ct = default)
		{
			var platformEntity = await repositoryManager.PlatformRepository.GetPlatformById(id, false, ct);
			if (platformEntity is null)
			{
				throw new NotFoundException($"Platform not found.");
			}
			return mapper.Map<PlatformForReturnDto>(platformEntity);
		}

		public async Task<IEnumerable<PlatformForReturnDto>> GetPlatforms(CancellationToken ct = default)
		{
			var platformEntities = await repositoryManager.PlatformRepository.GetPlatforms(false, ct);
			return mapper.Map<IEnumerable<PlatformForReturnDto>>(platformEntities);
		}

		public async Task UpdatePlatform(Guid id, PlatformForUpdateDto platformForUpdateDto, CancellationToken ct = default)
		{
			var platformEntity = await repositoryManager.PlatformRepository.GetPlatformById(id, true, ct);
			if (platformEntity is null)
			{
				throw new NotFoundException($"Platform not found.");
			}
			mapper.Map(platformForUpdateDto, platformEntity);
			await repositoryManager.SaveAsync(ct);
		}
	}
}
