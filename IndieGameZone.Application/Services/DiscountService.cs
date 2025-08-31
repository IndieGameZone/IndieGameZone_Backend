using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Discounts;
using MapsterMapper;

namespace IndieGameZone.Application.Services
{
	internal sealed class DiscountService : IDiscountService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public DiscountService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}
		public async Task CreateDiscount(Guid gameId, DiscountForCreationDto discountForCreationDto, CancellationToken ct = default)
		{
			var currentDiscount = await repositoryManager.DiscountRepository.GetActiveDiscountByGameId(gameId, false, ct);
			if (currentDiscount != null)
			{
				throw new BadRequestException("An active discount already exists for this game.");
			}
			var latestDiscount = await repositoryManager.DiscountRepository.GetLatestDiscountByGameId(gameId, false, ct);
			int daysSinceLatestDiscount = DateOnly.FromDateTime(DateTime.Now).DayNumber - latestDiscount.EndDate.DayNumber;
			if (daysSinceLatestDiscount < 30)
			{
				throw new BadRequestException("A new discount can only be created 30 days after the end of the last discount.");
			}

			var discountEntity = mapper.Map<Discounts>(discountForCreationDto);
			discountEntity.Id = Guid.NewGuid();
			discountEntity.GameId = gameId;
			repositoryManager.DiscountRepository.CreateDiscount(discountEntity);
			await repositoryManager.SaveAsync(ct);
		}
	}
}
