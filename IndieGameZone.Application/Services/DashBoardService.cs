using Bogus.DataSets;
using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Responses.DashBoard;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;
using MapsterMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Application.Services
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
                    ? games[i].Game.Price - games[i].Game.Price * discount.Percentage / 100
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
                    ? games[i].Price - games[i].Price * discount.Percentage / 100
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

        public async Task<double> GetTotalRevenueFromGamePurchaseByDeveloperAsync(RevenueRange range, CancellationToken ct = default)
        {
            return await repositoryManager.TransactionRepository.GetTotalRevenueFromGamePurchaseByDeveloper(range, ct) + await repositoryManager.TransactionRepository.GetTotalRevenueFromDonation(range, ct);
        }

        public async Task<double> GetTotalRevenueFromGamePurchaseByAdminAsync(RevenueRange range, CancellationToken ct = default)
        {
            return await repositoryManager.TransactionRepository.GetTotalRevenueFromGamePurchaseByAdmin(range, ct);
        }

        public async Task<double> GetTotalRevenueFromCommercialPackagePurchaseAsync(RevenueRange range, CancellationToken ct = default)
        {
            return await repositoryManager.TransactionRepository.GetTotalRevenueFromCommercialPackagePurchase(range, ct);
        }

        public async Task<DashboardSummaryForReturnDto> GetDashboardSummaryAsync(RevenueRange range, CancellationToken ct = default)
        {
            var onlineUserCount = await GetOnlineUserCountAsync(ct);
            var totalUserCount = await GetTotalUserCountAsync(ct);
            var gameRevenueByDeveloper = await GetTotalRevenueFromGamePurchaseByDeveloperAsync(range, ct);
            var gameRevenueByAdmin = await GetTotalRevenueFromGamePurchaseByAdminAsync(range, ct);
            var commercialRevenue = await GetTotalRevenueFromCommercialPackagePurchaseAsync(range, ct);

            return new DashboardSummaryForReturnDto
            {
                OnlineUserCount = onlineUserCount,
                TotalUserCount = totalUserCount,
                GamePurchaseRevenueByDeveloper = gameRevenueByDeveloper,
                GamePurchaseRevenueByAdmin = gameRevenueByAdmin,
                CommercialPackageRevenue = commercialRevenue
            };

        }

        public async Task<IEnumerable<AdminRevenueByDayForReturnDto>> GetAdminRevenueByMonthAsync(int year, int month, CancellationToken ct = default)
        {
            return await repositoryManager.TransactionRepository
                .GetAdminRevenueByMonthAsync(year, month, ct);
        }

        public async Task<DeveloperDashboardSummaryForReturnDto> GetDeveloperDashboardAsync(Guid developerId, CancellationToken ct = default)
        {
            // 1. Total revenue (all time)
            var totalRevenue = await repositoryManager.TransactionRepository
                .GetTotalRevenueForDeveloper(developerId, RevenueRange.AllTime, ct);

            // 2. Total donation (all time)
            var totalDonations = await repositoryManager.TransactionRepository
                .GetTotalDonationForDeveloper(developerId, RevenueRange.AllTime, ct);

            // 3. Find first month the developer received revenue
            var firstTransactionDate = await repositoryManager.TransactionRepository
                .GetFirstTransactionDateForDeveloper(developerId, ct);

            var revenueByMonth = new Dictionary<string, double>();
            if (firstTransactionDate != null)
            {
                var firstMonth = new DateTime(firstTransactionDate.Value.Year, firstTransactionDate.Value.Month, 1);
                var currentMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

                while (firstMonth <= currentMonth)
                {
                    var start = firstMonth;
                    var end = firstMonth.AddMonths(1).AddTicks(-1);

                    var monthlyRevenue = await repositoryManager.TransactionRepository
                        .GetTotalRevenueForDeveloper(developerId, start, end, ct);

                    var monthlyDonations = await repositoryManager.TransactionRepository
                        .GetTotalDonationForDeveloper(developerId, start, end, ct);

                    revenueByMonth[start.ToString("yyyy-MM")] = monthlyRevenue + monthlyDonations;

                    firstMonth = firstMonth.AddMonths(1);
                }
            }

            // 4. Top 5 best-downloaded games
            var allDeveloperGames = await repositoryManager.GameRepository
                .GetGamesByDeveloperId(developerId, new GameParameters { PageNumber = 1, PageSize = int.MaxValue }, false, ct);

            var downloadCounts = new List<(Games game, int count)>();

            foreach (var game in allDeveloperGames)
            {
                var totalDownloads = await repositoryManager.DownloadSlotRepository
                    .GetTotalDownloadsByGameIdAsync(game.Id, ct);

                downloadCounts.Add((game, totalDownloads));
            }

            var topDownloadedGamesDto = downloadCounts
                .OrderByDescending(x => x.count)
                .Take(5)
                .Select(x => new GameWithDownloadsDto
                {
                    Game = mapper.Map<GameForListReturnDto>(x.game),
                    NumberOfDownloads = x.count
                });

            return new DeveloperDashboardSummaryForReturnDto
            {
                TotalRevenueAllTime = totalRevenue + totalDonations,
                TotalDonationAllTime = totalDonations,
                RevenueByMonth = revenueByMonth,
                Top5BestDownloadedGames = topDownloadedGamesDto
            };
        }

        public async Task<IEnumerable<RevenueByDayForReturnDto>> GetRevenueByMonthAsync(Guid developerId, int year, int month, CancellationToken ct = default)
        {
            return await repositoryManager.TransactionRepository.GetRevenueByMonthAsync(developerId, year, month, ct);
        }

        public async Task<GameDashboardSummaryForReturnDto> GetGameDashboardAsync(Guid gameId, CancellationToken ct = default)
        {
            var totalRevenue = await repositoryManager.TransactionRepository
                .GetTotalRevenueForGame(gameId, DateTime.MinValue, DateTime.Now, ct);
            
            var totalDonations = await repositoryManager.TransactionRepository
                .GetTotalDonationForGame(gameId, RevenueRange.AllTime, ct);

            var firstTransactionDate = await repositoryManager.TransactionRepository
                .GetFirstTransactionDateForGame(gameId, ct);

            var revenueByMonth = new Dictionary<string, double>();

            if (firstTransactionDate != null)
            {
                var firstMonth = new DateTime(firstTransactionDate.Value.Year, firstTransactionDate.Value.Month, 1);
                var currentMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

                while (firstMonth <= currentMonth)
                {
                    var start = firstMonth;
                    var end = firstMonth.AddMonths(1).AddTicks(-1);

                    var monthlyRevenue = await repositoryManager.TransactionRepository
                        .GetTotalRevenueForGame(gameId, start, end, ct);

                    var monthlyDonation = await repositoryManager.TransactionRepository
                        .GetTotalDonationForGame(gameId, start, end, ct);

                    revenueByMonth[start.ToString("yyyy-MM")] = monthlyRevenue + monthlyDonation;

                    firstMonth = firstMonth.AddMonths(1);
                }
            }
            
            var totalDownloads = await repositoryManager.DownloadSlotRepository
                .GetTotalDownloadsByGameIdAsync(gameId, ct);

            return new GameDashboardSummaryForReturnDto
            {
                TotalRevenueAllTime = totalRevenue + totalDonations,
                TotalDonationAllTime = totalDonations,
                RevenueByMonth = revenueByMonth,
                TotalDownloadsAllTime = totalDownloads
            };
        }

        public async Task<IEnumerable<GameMonthlyStatsByDayForReturnDto>> GetGameMonthlyStatsAsync(Guid gameId, int year, int month, CancellationToken ct = default)
        {
            // 1. Get revenue + donation breakdown from repo
            var revenueData = (await repositoryManager.TransactionRepository
                .GetGameRevenueAndDonationsByMonthAsync(gameId, year, month, ct))
                .ToList();

            // 2. Get downloads for the same month
            var downloads = await repositoryManager.DownloadSlotRepository
                .GetDownloadCountsByGameIdAsync(gameId, year, month, ct);

            var downloadDict = downloads.ToDictionary(d => d.day, d => d.numberOfDownloads);

            // 3. Merge download counts into the revenue data
            foreach (var dayStat in revenueData)
            {
                if (downloadDict.TryGetValue(dayStat.Day, out var count))
                {
                    dayStat.DownloadCount = (int)count;
                }
            }

            return revenueData;
        }

        public async Task<double> GetTotalCurrentBalanceOfAllDevelopersAsync(CancellationToken ct = default)
        {
            var devIds = (await userManager.GetUsersInRoleAsync(RoleEnum.Developer.ToString()))
                .Select(u => u.Id)
                .ToList();
            
            return await repositoryManager.WalletRepository.GetTotalBalanceByUserIdsAsync(devIds, ct);
        }

        public async Task<double> GetAdminBankBalanceAsync(CancellationToken ct = default)
        {
            // Get all Admin IDs
            var adminIds = (await userManager.GetUsersInRoleAsync(RoleEnum.Admin.ToString()))
                .Select(u => u.Id)
                .ToList();

            // Get all Developer IDs
            var devIds = (await userManager.GetUsersInRoleAsync(RoleEnum.Developer.ToString()))
                .Select(u => u.Id)
                .ToList();

            // Sum balances for Admins
            var adminBalance = await repositoryManager.WalletRepository.GetTotalBalanceByUserIdsAsync(adminIds, ct);

            // Sum balances for Devs
            var devBalance = await repositoryManager.WalletRepository.GetTotalBalanceByUserIdsAsync(devIds, ct);

            // Return the total as double
            return (adminBalance + devBalance);
        }

    }
}
