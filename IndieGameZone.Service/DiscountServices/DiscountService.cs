using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Discounts;
using MapsterMapper;

namespace IndieGameZone.Application.DiscountServices
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
			var discountEntity = mapper.Map<Discounts>(discountForCreationDto);
			discountEntity.Id = Guid.NewGuid();
			discountEntity.GameId = gameId;
			repositoryManager.DiscountRepository.CreateDiscount(discountEntity);
			await repositoryManager.SaveAsync(ct);
		}
	}
}
