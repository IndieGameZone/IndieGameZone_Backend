using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestsAndResponses.Responses.ActivationKeys;
using MapsterMapper;

namespace IndieGameZone.Application.Services
{
	internal sealed class ActivationKeyService : IActivationKeyService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public ActivationKeyService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}

		private async Task<bool> CheckGameOwnership(Guid userId, Guid gameId, CancellationToken ct = default)
		{
			var gameLibrary = await repositoryManager.LibraryRepository.GetLibraryByUserIdAndGameId(userId, gameId, false, ct);
			return gameLibrary != null;
		}

		public async Task<ActivationKeyForReturnDto> GetKeyByGamePlatformId(Guid userId, Guid gamePlatformId, CancellationToken ct = default)
		{
			var gamePlatform = await repositoryManager.GamePlatformRepository.GetGamePlatformsById(gamePlatformId, false, ct);
			if (!await CheckGameOwnership(userId, gamePlatform.GameId, ct))
			{
				throw new BadRequestException("You must own this game to see the activation key.");
			}
			var key = await repositoryManager.ActivationKeyRepository.GetByGamePlatformId(gamePlatformId, false, ct);
			if (key == null) throw new NotFoundException("Key not found");
			return mapper.Map<ActivationKeyForReturnDto>(key);
		}

		public async Task<bool> ValidateActivationKey(string activationKey, CancellationToken ct = default)
		{
			var key = await repositoryManager.ActivationKeyRepository.GetByKey(activationKey, false, ct);
			if (key == null) throw new NotFoundException("Key not found");
			if (key.IsUsed) throw new BadRequestException("Key already used");
			return true;
		}
	}
}
