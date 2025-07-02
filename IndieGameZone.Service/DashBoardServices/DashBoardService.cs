using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Application.DashBoardServices
{
    internal sealed class DashBoardService : IDashBoardService
    {
        private readonly IRepositoryManager repositoryManager;
        private readonly IMapper mapper;

        public DashBoardService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            this.repositoryManager = repositoryManager;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<GameForListReturnDto>> GetTop10MostDownloadedGamesAsync(CancellationToken ct = default)
        {
            var gameEntities = await repositoryManager.GameRepository.GetTop10MostDownloadedGames(trackChange: false, ct);
            var games = mapper.Map<List<GameForListReturnDto>>(gameEntities);

            for (int i = 0; i < games.Count; i++)
            {
                var discount = await repositoryManager.DiscountRepository.GetActiveDiscountByGameId(gameEntities.ElementAt(i).Id, trackChange: false, ct);
                games[i].PriceAfterDiscount = discount is not null
                    ? games[i].Price - (games[i].Price * discount.Percentage / 100)
                    : games[i].Price;
            }

            return games;
        }

    }
}
