using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;
using MapsterMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
        private readonly UserManager<Users> userManager;

        public DashBoardService(IRepositoryManager repositoryManager, IMapper mapper, UserManager<Users> userManager)
        {
            this.repositoryManager = repositoryManager;
            this.mapper = mapper;
            this.userManager = userManager;
        }

        public async Task<IEnumerable<GameWithDownloadsDto>> GetTopDownloadedGamesAsync(int top = 10, CancellationToken ct = default)
        {
            var gameEntities = await repositoryManager.GameRepository.GetTopDownloadedGames(top, trackChange: false, ct);

            // Map and build a list of GameWithDownloadsDto
            var games = gameEntities.Select(game => new GameWithDownloadsDto
            {
                Game = mapper.Map<GameForListReturnDto>(game),
                NumberOfDownloads = game.NumberOfDownloads
            }).ToList(); // Convert to list so we can index it

            // Apply discount logic
            for (int i = 0; i < games.Count; i++)
            {
                var discount = await repositoryManager.DiscountRepository
                    .GetActiveDiscountByGameId(gameEntities.ElementAt(i).Id, trackChange: false, ct);

                games[i].Game.PriceAfterDiscount = discount is not null
                    ? games[i].Game.Price - (games[i].Game.Price * discount.Percentage / 100)
                    : games[i].Game.Price;
            }

            return games;
        }

        public async Task<IEnumerable<GameWithSalesDto>> GetTopSellingGamesWithCountAsync(int top = 10, CancellationToken ct = default)
        {
            var gameWithCounts = await repositoryManager.LibraryRepository.GetTopSellingGames(top, ct);

            var result = gameWithCounts.Select(pair => new GameWithSalesDto
            {
                Game = mapper.Map<GameForListReturnDto>(pair.game),
                PurchaseCount = pair.purchaseCount
            });

            return result.OrderByDescending(x => x.PurchaseCount);
        }

        public async Task<IEnumerable<GameWithRatingDto>> GetTopRatedGamesAsync(int top = 10, CancellationToken ct = default)
        {
            var ratedGames = await repositoryManager.GameRepository.GetTopRatedGames(top, false, ct);

            var result = ratedGames.Select(pair => new GameWithRatingDto
            {
                Game = mapper.Map<GameForListReturnDto>(pair.game),
                AverageRating = Math.Round(pair.averageRating, 2)
            });

            return result.OrderByDescending(x => x.AverageRating);
        }

        public async Task<IEnumerable<GameForListReturnDto>> GetRecentlyPublishedGamesAsync(int top = 10, CancellationToken ct = default)
        {
            var gameEntities = await repositoryManager.GameRepository.GetRecentlyPublishedGames(top, trackChange: false, ct);

            var games = mapper.Map<List<GameForListReturnDto>>(gameEntities);

            for (int i = 0; i < games.Count; i++)
            {
                var discount = await repositoryManager.DiscountRepository
                    .GetActiveDiscountByGameId(gameEntities.ElementAt(i).Id, trackChange: false, ct);

                games[i].PriceAfterDiscount = discount is not null
                    ? games[i].Price - (games[i].Price * discount.Percentage / 100)
                    : games[i].Price;
            }

            return games;
        }

        public async Task<int> GetOnlineUserCountAsync(CancellationToken ct = default)
        {
            var threshold = DateTime.Now.AddMinutes(-5);
            return await repositoryManager.UserProfileRepository.CountUsersPingedAfter(threshold, ct);
        }

        public async Task<int> GetTotalUserCountAsync(CancellationToken ct = default)
        {
            return await userManager.Users.CountAsync(ct);
        }
    }
}
