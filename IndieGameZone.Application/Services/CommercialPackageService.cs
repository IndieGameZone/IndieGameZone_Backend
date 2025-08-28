using IndieGameZone.Application.BackgroundJobServices;
using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.CommercialPackages;
using IndieGameZone.Domain.RequestsAndResponses.Responses.CommercialPackages;
using MapsterMapper;
using Microsoft.AspNetCore.Identity;
using Quartz;

namespace IndieGameZone.Application.Services
{
	internal sealed class CommercialPackageService : ICommercialPackageService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly ISchedulerFactory schedulerFactory;
        private readonly UserManager<Users> userManager;

        public CommercialPackageService(IRepositoryManager repositoryManager, IMapper mapper, ISchedulerFactory schedulerFactory, UserManager<Users> userManager)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.schedulerFactory = schedulerFactory;
            this.userManager = userManager;
        }
		public async Task CreateCommercialPackage(CommercialPackageForCreationDto commercialPackageForCreationDto, CancellationToken ct = default)
		{
			var commercialPackageEntity = mapper.Map<CommercialPackages>(commercialPackageForCreationDto);
			commercialPackageEntity.Id = Guid.NewGuid();
			repositoryManager.CommercialPackageRepository.CreateCommercialPackage(commercialPackageEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task DeleteCommercialPackage(Guid id, CancellationToken ct = default)
		{
			var commercialPackageEntity = await repositoryManager.CommercialPackageRepository.GetCommercialPackageById(id, true, ct);
			if (commercialPackageEntity is null)
			{
				throw new NotFoundException($"Commercial Package not found.");
			}
			commercialPackageEntity.IsDeleted = true;
			await repositoryManager.SaveAsync(ct);
		}

		public async Task<CommercialPackageForReturnDto> GetCommercialPackageById(Guid id, CancellationToken ct = default)
		{
			var commercialPackageEntity = await repositoryManager.CommercialPackageRepository.GetCommercialPackageById(id, false, ct);
			if (commercialPackageEntity is null)
			{
				throw new NotFoundException($"Commercial Package not found.");
			}
			return mapper.Map<CommercialPackageForReturnDto>(commercialPackageEntity);
		}

		public async Task<(IEnumerable<CommercialPackageForReturnDto> commercialPackages, MetaData metaData)> GetCommercialPackages(CommercialPackageParameters commercialPackageParameters, CancellationToken ct = default)
		{
			var commercialPackagesWithMetaData = await repositoryManager.CommercialPackageRepository.GetCommercialPackages(commercialPackageParameters, false, ct);
			var commercialPackages = mapper.Map<IEnumerable<CommercialPackageForReturnDto>>(commercialPackagesWithMetaData);
			return (commercialPackages, commercialPackagesWithMetaData.MetaData);
		}

		public async Task UpdateCommercialPackage(Guid id, CommercialPackageForUpdateDto commercialPackageForUpdateDto, CancellationToken ct = default)
		{
			var commercialPackageEntity = await repositoryManager.CommercialPackageRepository.GetCommercialPackageById(id, true, ct);
			if (commercialPackageEntity is null)
			{
				throw new NotFoundException($"Commercial Package not found.");
			}
			mapper.Map(commercialPackageForUpdateDto, commercialPackageEntity);
			await repositoryManager.SaveAsync(ct);
		}

		private async Task<(IEnumerable<CommercialRegistrationForReturnDto> commercialRegistrations, MetaData metaData)>
			GetCommercialRegistrationsByUser(Guid userId, CommercialRegistrationParameters commercialRegistrationParameters, CancellationToken ct = default)
		{
			var commercialRegistrationsWithMetaData = await repositoryManager.CommercialRegistrationRepository
				.GetCommercialRegistrationsByUser(userId, commercialRegistrationParameters, false, ct);

			var commercialRegistrations = mapper.Map<List<CommercialRegistrationForReturnDto>>(commercialRegistrationsWithMetaData);

			for (int i = 0; i < commercialRegistrations.Count; i++)
			{
				commercialRegistrations[i].Visibility = commercialRegistrationsWithMetaData[i].Game.Visibility;
			}

			return (commercialRegistrations, commercialRegistrationsWithMetaData.MetaData);
		}

		private async Task<(IEnumerable<CommercialRegistrationForReturnDto> commercialRegistrations, MetaData metaData)>
			GetCommercialRegistrationsByGame(Guid gameId, CommercialRegistrationParameters commercialRegistrationParameters, CancellationToken ct = default)
		{
			var commercialRegistrationsWithMetaData = await repositoryManager.CommercialRegistrationRepository
				.GetCommercialRegistrationsByGame(gameId, commercialRegistrationParameters, false, ct);

			var commercialRegistrations = mapper
				.Map<List<CommercialRegistrationForReturnDto>>(commercialRegistrationsWithMetaData);

			for (int i = 0; i < commercialRegistrations.Count; i++)
			{
				commercialRegistrations[i].Visibility = commercialRegistrationsWithMetaData[i].Game.Visibility;
			}

			return (commercialRegistrations, commercialRegistrationsWithMetaData.MetaData);
		}

		private async Task<(IEnumerable<CommercialRegistrationForReturnDto> commercialRegistrations, MetaData metaData)>
			GetCommercialRegistrationsByPackage(Guid commercialPackageId, CommercialRegistrationParameters commercialRegistrationParameters, CancellationToken ct = default)
		{
			var commercialRegistrationsWithMetaData = await repositoryManager.CommercialRegistrationRepository
				.GetCommercialRegistrationsByPackage(commercialPackageId, commercialRegistrationParameters, false, ct);

			var commercialRegistrations = mapper
				.Map<List<CommercialRegistrationForReturnDto>>(commercialRegistrationsWithMetaData);

			for (int i = 0; i < commercialRegistrations.Count; i++)
			{
				commercialRegistrations[i].Visibility = commercialRegistrationsWithMetaData[i].Game.Visibility;
			}

			return (commercialRegistrations, commercialRegistrationsWithMetaData.MetaData);
		}

		public async Task<(IEnumerable<CommercialRegistrationForReturnDto> commercialRegistrations, MetaData metaData)>
			GetFilteredCommercialRegistrations(Guid? userId, Guid? gameId, Guid? commercialPackageId, CommercialRegistrationParameters commercialRegistrationParameters, CancellationToken ct = default)
		{
			// Ensure only one parameter is used
			int filterCount = 0;
			if (userId.HasValue) filterCount++;
			if (gameId.HasValue) filterCount++;
			if (commercialPackageId.HasValue) filterCount++;

			if (filterCount > 1)
				throw new BadRequestException("You cannot filter by more than one of: userId, gameId, or commercialPackageId.");

			if (userId.HasValue)
				return await GetCommercialRegistrationsByUser(userId.Value, commercialRegistrationParameters, ct);

			if (gameId.HasValue)
				return await GetCommercialRegistrationsByGame(gameId.Value, commercialRegistrationParameters, ct);

			if (commercialPackageId.HasValue)
				return await GetCommercialRegistrationsByPackage(commercialPackageId.Value, commercialRegistrationParameters, ct);

			// No filter applied, return all
			var commercialRegistrationsWithMetaData = await repositoryManager.CommercialRegistrationRepository
				.GetCommercialRegistrations(commercialRegistrationParameters, false, ct);

			var commercialRegistrations = mapper.Map<List<CommercialRegistrationForReturnDto>>(commercialRegistrationsWithMetaData);

			for (int i = 0; i < commercialRegistrations.Count; i++)
			{
				commercialRegistrations[i].Visibility = commercialRegistrationsWithMetaData[i].Game.Visibility;
			}

			return (commercialRegistrations, commercialRegistrationsWithMetaData.MetaData);
		}

		public async Task<List<DateOnly>> GetUnavailableDatesAsync(Guid packageId, Guid gameId, Guid userId, CancellationToken ct = default)
		{
			// Validate game existence and ownership
			var game = await repositoryManager.GameRepository.GetGameById(gameId, false, ct)
					   ?? throw new NotFoundException("Game not found.");

			if (game.DeveloperId != userId)
				throw new ForbiddenException("You are not allowed to register ads for a game you do not own.");

			// Validate package existence
			var package = await repositoryManager.CommercialPackageRepository.GetCommercialPackageById(packageId, false, ct)
						  ?? throw new NotFoundException("Commercial package not found.");

			// Fetch relevant registrations using package type and game category
			var relevantRegistrations = await repositoryManager.CommercialRegistrationRepository
				.GetRelevantRegistrationsForDateCheckAsync(package.Type, game.CategoryId, ct);

			var dateCounter = new Dictionary<DateOnly, int>();
			var gameSpecificDates = new HashSet<DateOnly>();

			foreach (var reg in relevantRegistrations)
			{
				if (reg.GameId == gameId)
				{
					// This game already has a registration on these dates
					for (var date = reg.StartDate; date < reg.EndDate!.Value; date = date.AddDays(1))
						gameSpecificDates.Add(date);
				}

				for (var date = reg.StartDate; date < reg.EndDate!.Value; date = date.AddDays(1))
				{
					if (!dateCounter.ContainsKey(date))
						dateCounter[date] = 0;

					dateCounter[date]++;
				}
			}

			var unavailableDates = new List<DateOnly>();

			foreach (var kvp in dateCounter)
			{
				if ((package.Type == CommercialPackageType.HomepageBanner && kvp.Value >= 10) ||
					(package.Type == CommercialPackageType.CategoryBanner && kvp.Value >= 10))
				{
					unavailableDates.Add(kvp.Key);
				}
			}

			// Add dates already taken by this game
			unavailableDates.AddRange(gameSpecificDates);

			// Remove duplicates and order
			return unavailableDates
				.Distinct()
				.OrderBy(d => d)
				.ToList();
		}

		public async Task<int> RunStatusUpdateAsync(CancellationToken ct = default)
		{
			var localTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow,
				TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"));

			var today = DateOnly.FromDateTime(localTime);

			var registrations = await repositoryManager.CommercialRegistrationRepository
				.GetRegistrationsForStatusUpdate(today, ct);

			int updatedCount = 0;

			foreach (var reg in registrations)
			{
				switch (reg.Status)
				{
					case CommercialRegistrationStatus.Pending:
						if (reg.EndDate.HasValue && reg.EndDate.Value <= today)
						{
							reg.Status = CommercialRegistrationStatus.Expired;
							updatedCount++;
						}
						else if (reg.StartDate == today)
						{
							if (reg.Game.Visibility == GameVisibility.Public)
							{
								reg.Status = CommercialRegistrationStatus.Active;
							}
							else
							{
								reg.Status = CommercialRegistrationStatus.Failed;
							}
							updatedCount++;
						}
						break;

					case CommercialRegistrationStatus.Active:
						if (reg.EndDate.HasValue && reg.EndDate.Value <= today)
						{
							reg.Status = CommercialRegistrationStatus.Expired;
							updatedCount++;
						}
						break;

					case CommercialRegistrationStatus.Failed:
						if (reg.StartDate <= today && (!reg.EndDate.HasValue || today <= reg.EndDate.Value))
						{
							if (reg.Game.Visibility == GameVisibility.Public && reg.Game.CensorStatus == CensorStatus.Approved)
							{
								reg.Status = CommercialRegistrationStatus.Active;
								updatedCount++;
							}
						}
						break;
				}
			}

			if (updatedCount > 0)
			{
				await repositoryManager.SaveAsync(ct);
			}

			return updatedCount;
		}

		public async Task CancelCommercialRegistrationAsync(Guid registrationId, Guid developerId, CancellationToken ct)
		{
            var developer = await userManager.FindByIdAsync(developerId.ToString());

            if (developer == null)
                throw new NotFoundException("Developer not found.");

            var registration = await repositoryManager
				.CommercialRegistrationRepository
				.GetCommercialRegistrationById(registrationId, trackChange: true, ct);

			if (registration == null)
				throw new NotFoundException($"Commercial registration not found.");

			if (registration.Game.DeveloperId != developerId)
				throw new ForbiddenException($"You can only cancel your own registration.");

			var package = registration.CommercialPackage;
			if (package == null)
				throw new NotFoundException($"Commercial package not found.");

			var game = await repositoryManager
				.GameRepository
				.GetGameById(registration.GameId, trackChange: false, ct);

			if (game == null)
				throw new NotFoundException($"Game associated with registration not found.");

			var wallet = await repositoryManager
				.WalletRepository
				.GetWalletByUserId(developerId, trackChange: true, ct);

			if (wallet == null)
				throw new NotFoundException($"Wallet not found.");

			var now = DateTime.Now;
			var startDate = registration.StartDate.ToDateTime(TimeOnly.MinValue);

			// Compose DateTime thresholds for refund policy
			var dayBeforeStart = startDate.AddDays(-1);

			var fullRefundCutoff = dayBeforeStart;
			var fiftyPercentCutoff = dayBeforeStart.AddHours(12);    // 12:00 noon
			var thirtyPercentCutoff = dayBeforeStart.AddHours(18);   // 18:00 (6 PM)
			var noRefundCutoff = startDate;                          // 00:00 of StartDate

			double refundPercent;

			if (now < fullRefundCutoff)
			{
				refundPercent = 0.7;
			}
			else if (now >= fullRefundCutoff && now < fiftyPercentCutoff)
			{
				refundPercent = 0.5;
			}
			else if (now >= fiftyPercentCutoff && now < thirtyPercentCutoff)
			{
				refundPercent = 0.3;
			}
			else if (now >= thirtyPercentCutoff && now < noRefundCutoff)
			{
				refundPercent = 0;
			}
			else
			{
				throw new BadRequestException("You can no longer cancel this registration.");
			}

			decimal refundAmount = (decimal)(package.Price * refundPercent);

            var adminId = Guid.Parse("e5d8947f-6794-42b6-ba67-201f366128b8"); // hardcoded admin ID
            var adminWallet = await repositoryManager
                .WalletRepository
                .GetWalletByUserId(adminId, trackChange: true, ct);

            if (adminWallet == null)
                throw new NotFoundException("Admin wallet not found.");

            if (adminWallet.Balance < (double)refundAmount)
                throw new BadRequestException("Admin does not have enough funds to process the refund.");

            // If refund > 0, get admin wallet and transfer funds
            if (refundAmount > 0)
			{
				// Transfer from admin to developer
				adminWallet.Balance -= (double)refundAmount;
				wallet.Balance += (double)refundAmount;
			}

			// Always log the transaction
			repositoryManager.TransactionRepository.CreateTransaction(new Transactions
			{
				Id = Guid.NewGuid(),
				UserId = Guid.Parse("e5d8947f-6794-42b6-ba67-201f366128b8"),
				PurchaseUserId = Guid.Parse("e5d8947f-6794-42b6-ba67-201f366128b8"),
				OrderCode = null,
                InitialBalance = adminWallet.Balance + (double)refundAmount,
                Amount = (double)refundAmount,
                FinalBalance = adminWallet.Balance,
                Description = $"Refund {refundPercent * 100}% user {developer.UserName} for cancelling commercial registration {registration.CommercialPackage.Name}",
				CreatedAt = DateTime.Now,
				Type = TransactionType.RefundCommercialPackage,
				Status = TransactionStatus.Success,
				PaymentMethod = PaymentMethod.Wallet,
				GameId = game.Id

			});
			repositoryManager.TransactionRepository.CreateTransaction(new Transactions
			{
				Id = Guid.NewGuid(),
				UserId = developerId,
				PurchaseUserId = Guid.Parse("e5d8947f-6794-42b6-ba67-201f366128b8"),
				OrderCode = null,
                InitialBalance = wallet.Balance - (double)refundAmount,
                Amount = (double)refundAmount,
                FinalBalance = wallet.Balance,
                Description = $"Refund {refundPercent * 100}% for cancelling commercial registration {registration.CommercialPackage.Name}",
				CreatedAt = DateTime.Now,
				Type = TransactionType.ReceiveCommercialRefundPackage,
				Status = TransactionStatus.Success,
				PaymentMethod = PaymentMethod.Wallet,
				GameId = game.Id

			});

			// Always update registration status
			registration.Status = CommercialRegistrationStatus.Cancelled;

			await repositoryManager.SaveAsync(ct);
		}

		public async Task SetBackgroundJob(double minute, CancellationToken ct = default)
		{
			IJobDetail job = JobBuilder.Create<UpdateCommercialRegistrationStatusJob>()
				.WithIdentity("CommercialRegistrationJob", "CommercialRegistrationGroup")
				.Build();

			var time = DateTimeOffset.Now.AddMinutes(minute);

			ITrigger trigger = TriggerBuilder.Create()
				.WithIdentity("CommercialRegistrationTrigger", "CommercialRegistrationGroup")
				.StartAt(time)
				.Build();

			var scheduler = await schedulerFactory.GetScheduler(ct);

			await scheduler.ScheduleJob(job, trigger, ct);
		}
	}
}
