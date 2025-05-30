using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestsAndResponses.Requests.GameTypes;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GameTypes;
using MapsterMapper;

namespace IndieGameZone.Application.GameTypeServices
{
	internal sealed class GameTypeService : IGameTypeService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public GameTypeService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}

		public async Task CreateGameType(GameTypeForCreationDto gameTypeForCreationDto, CancellationToken ct = default)
		{
			var gameStatusEntity = mapper.Map<GameTypes>(gameTypeForCreationDto);
			gameStatusEntity.Id = Guid.NewGuid();
			repositoryManager.GameTypeRepository.CreateGameType(gameStatusEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task DeleteGameType(Guid id, CancellationToken ct = default)
		{
			var gameStatusEntity = await repositoryManager.GameTypeRepository.GetGameTypeById(id, false, ct);
			if (gameStatusEntity is null)
			{
				throw new NotFoundException($"Game status not found.");
			}
			repositoryManager.GameTypeRepository.DeleteGameType(gameStatusEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task<GameTypeForReturnDto> GetGameTypeById(Guid id, CancellationToken ct = default)
		{
			var gameStatusEntity = await repositoryManager.GameTypeRepository.GetGameTypeById(id, false, ct);
			if (gameStatusEntity is null)
			{
				throw new NotFoundException($"Game status not found.");
			}
			return mapper.Map<GameTypeForReturnDto>(gameStatusEntity);
		}

		public async Task<IEnumerable<GameTypeForReturnDto>> GetGameTypes(CancellationToken ct = default)
		{
			var gameStatusEntities = await repositoryManager.GameTypeRepository.GetGameTypes(false, ct);
			return mapper.Map<IEnumerable<GameTypeForReturnDto>>(gameStatusEntities);
		}

		public async Task UpdateGameType(Guid id, GameTypeForUpdateDto gameTypeForUpdateDto, CancellationToken ct = default)
		{
			var gameStatusEntity = await repositoryManager.GameTypeRepository.GetGameTypeById(id, true, ct);
			if (gameStatusEntity is null)
			{
				throw new NotFoundException($"Game status not found.");
			}
			mapper.Map(gameTypeForUpdateDto, gameStatusEntity);
			await repositoryManager.SaveAsync(ct);
		}
	}
}
