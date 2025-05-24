using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;
using MapsterMapper;

namespace IndieGameZone.Application.GameServices
{
	internal sealed class GameService : IGameService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public GameService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}

		public async Task<(IEnumerable<GameForListReturnDto> games, MetaData metaData)> GetGames(GameParameters gameParameters, CancellationToken ct = default)
		{
			var gamesWithMetaData = await repositoryManager.GameRepository.GetGames(gameParameters, false, ct);
			var games = mapper.Map<IEnumerable<GameForListReturnDto>>(gamesWithMetaData);
			return (games, gamesWithMetaData.MetaData);
		}

		public async Task<GameForSingleReturnDto> GetGameById(Guid gameId, CancellationToken ct = default)
		{
			var gameEntity = await repositoryManager.GameRepository.GetGameById(gameId, false, ct);
			if (gameEntity is null)
			{
				throw new NotFoundException($"Game not found.");
			}
			return mapper.Map<GameForSingleReturnDto>(gameEntity);
		}

		public async Task DeleteGame(Guid developerId, Guid gameId, CancellationToken ct = default)
		{
			var gameEntity = await repositoryManager.GameRepository.GetGameById(gameId, false, ct);
			if (gameEntity is null)
			{
				throw new NotFoundException($"Game not found.");
			}
			if (gameEntity.DeveloperId != developerId)
			{
				throw new ForbiddenException("You do not have permission to delete this game.");
			}
			repositoryManager.GameRepository.DeleteGame(gameEntity);
			await repositoryManager.SaveAsync(ct);
		}
	}
}
