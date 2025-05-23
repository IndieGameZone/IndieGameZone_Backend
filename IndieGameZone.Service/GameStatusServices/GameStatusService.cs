using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestsAndResponses.Requests.GameStatuses;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GameStatuses;
using MapsterMapper;

namespace IndieGameZone.Application.GameStatusServices
{
	internal sealed class GameStatusService : IGameStatusService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public GameStatusService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}

		public async Task CreateGameStatus(GameStatusForCreationDto gameStatusForCreationDto, CancellationToken ct = default)
		{
			var gameStatusEntity = mapper.Map<GameStatuses>(gameStatusForCreationDto);
			repositoryManager.GameStatusRepository.CreateGameStatus(gameStatusEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task DeleteGameStatus(Guid id, CancellationToken ct = default)
		{
			var gameStatusEntity = await repositoryManager.GameStatusRepository.GetGameStatusById(id, false, ct);
			if (gameStatusEntity is null)
			{
				throw new NotFoundException($"Game status not found.");
			}
			repositoryManager.GameStatusRepository.DeleteGameStatus(gameStatusEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task<GameStatusForReturnDto> GetGameStatusById(Guid id, CancellationToken ct = default)
		{
			var gameStatusEntity = await repositoryManager.GameStatusRepository.GetGameStatusById(id, false, ct);
			if (gameStatusEntity is null)
			{
				throw new NotFoundException($"Game status not found.");
			}
			return mapper.Map<GameStatusForReturnDto>(gameStatusEntity);
		}

		public async Task<IEnumerable<GameStatusForReturnDto>> GetGameStatuses(CancellationToken ct = default)
		{
			var gameStatusEntities = await repositoryManager.GameStatusRepository.GetGameStatuses(false, ct);
			return mapper.Map<IEnumerable<GameStatusForReturnDto>>(gameStatusEntities);
		}

		public async Task UpdateGameStatus(Guid id, GameStatusForUpdateDto gameStatusForUpdateDto, CancellationToken ct = default)
		{
			var gameStatusEntity = await repositoryManager.GameStatusRepository.GetGameStatusById(id, true, ct);
			if (gameStatusEntity is null)
			{
				throw new NotFoundException($"Game status not found.");
			}
			mapper.Map(gameStatusForUpdateDto, gameStatusEntity);
			await repositoryManager.SaveAsync(ct);
		}
	}
}
