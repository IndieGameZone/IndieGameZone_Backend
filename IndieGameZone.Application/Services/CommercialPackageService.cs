using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.CommercialPackages;
using IndieGameZone.Domain.RequestsAndResponses.Responses.CommercialPackages;
using MapsterMapper;

namespace IndieGameZone.Application.Services
{
	internal sealed class CommercialPackageService : ICommercialPackageService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public CommercialPackageService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
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
			var commercialPackageEntity = await repositoryManager.CommercialPackageRepository.GetCommercialPackageById(id, false, ct);
			if (commercialPackageEntity is null)
			{
				throw new NotFoundException($"Commercial Package not found.");
			}
			repositoryManager.CommercialPackageRepository.DeleteCommercialPackage(commercialPackageEntity);
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
				commercialRegistrations[i].CreatedAt = DateTime.Now;
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
				commercialRegistrations[i].CreatedAt = DateTime.Now;
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
				commercialRegistrations[i].CreatedAt = DateTime.Now;
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
				commercialRegistrations[i].CreatedAt = DateTime.Now;
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

	}
}
