using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GameCensorLogs;
using MapsterMapper;

namespace IndieGameZone.Application.GameCensorLogServices
{
	internal sealed class GameCensorLogService : IGameCensorLogService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public GameCensorLogService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}
		public async Task<(IEnumerable<GameCensorLogForReturnDto> gameCensorLogs, MetaData metaData)> GetGameCensorLogsByGameId(Guid gameId, GameCensorLogParameters gameCensorLogParameters, CancellationToken ct = default)
		{
			var gameCensorLogWithMetaData = await repositoryManager.GameCensorLogRepository.GetCensorLogByGameId(gameId, gameCensorLogParameters, false, ct);
			var gameCensorLogs = mapper.Map<IEnumerable<GameCensorLogForReturnDto>>(gameCensorLogWithMetaData);
			return (gameCensorLogs, gameCensorLogWithMetaData.MetaData);
		}
	}
}
