using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Responses.GamePriceLogs;
using MapsterMapper;

namespace IndieGameZone.Application.Services
{
	internal sealed class GamePriceLogService : IGamePriceLogService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public GamePriceLogService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}
		public async Task<(IEnumerable<GamePriceLogForReturnDto> gamePriceLogs, MetaData metaData)> GetGamePriceLogsByGameId(Guid gameId, GamePriceLogParameters gamePriceLogParameters, CancellationToken ct = default)
		{
			var gamePriceLogWithMetaData = await repositoryManager.GamePriceLogRepository.GetPriceLogByGameId(gameId, gamePriceLogParameters, false, ct);
			var gamePriceLogs = mapper.Map<IEnumerable<GamePriceLogForReturnDto>>(gamePriceLogWithMetaData);
			return (gamePriceLogs, gamePriceLogWithMetaData.MetaData);
		}
	}
}
