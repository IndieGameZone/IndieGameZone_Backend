using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestsAndResponses.Requests.AgeRestrictions;
using IndieGameZone.Domain.RequestsAndResponses.Responses.AgeRestrictions;
using MapsterMapper;

namespace IndieGameZone.Application.Services
{
	internal sealed class AgeRestrictionService : IAgeRestrictionService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public AgeRestrictionService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}
		public async Task CreateAgeRestriction(AgeRestrictionForCreationDto ageRestrictionForCreationDto, CancellationToken ct = default)
		{
			var ageRestrictionEntity = mapper.Map<Domain.Entities.AgeRestrictions>(ageRestrictionForCreationDto);
			ageRestrictionEntity.Id = Guid.NewGuid();
			repositoryManager.AgeRestrictionRepository.CreateAgeRestriction(ageRestrictionEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task DeleteAgeRestriction(Guid id, CancellationToken ct = default)
		{
			var ageRestrictionEntity = await repositoryManager.AgeRestrictionRepository.GetAgeRestrictionById(id, false, ct);
			if (ageRestrictionEntity is null)
			{
				throw new NotFoundException($"Age restriction not found.");
			}
			repositoryManager.AgeRestrictionRepository.DeleteAgeRestriction(ageRestrictionEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task<AgeRestrictionForReturnDto> GetAgeRestrictionById(Guid id, CancellationToken ct = default)
		{
			var ageRestrictionEntity = await repositoryManager.AgeRestrictionRepository.GetAgeRestrictionById(id, false, ct);
			if (ageRestrictionEntity is null)
			{
				throw new NotFoundException($"Age restriction not found.");
			}
			return mapper.Map<AgeRestrictionForReturnDto>(ageRestrictionEntity);
		}

		public async Task<IEnumerable<AgeRestrictionForReturnDto>> GetAgeRestrictions(CancellationToken ct = default)
		{
			var ageRestrictionEntities = await repositoryManager.AgeRestrictionRepository.GetAgeRestrictions(false, ct);
			return mapper.Map<IEnumerable<AgeRestrictionForReturnDto>>(ageRestrictionEntities);
		}

		public async Task UpdateAgeRestriction(Guid id, AgeRestrictionForUpdateDto ageRestrictionForUpdateDto, CancellationToken ct = default)
		{
			var ageRestrictionEntity = await repositoryManager.AgeRestrictionRepository.GetAgeRestrictionById(id, true, ct);
			if (ageRestrictionEntity is null)
			{
				throw new NotFoundException($"Age restriction not found.");
			}
			mapper.Map(ageRestrictionForUpdateDto, ageRestrictionEntity);
			await repositoryManager.SaveAsync(ct);
		}
	}
}
