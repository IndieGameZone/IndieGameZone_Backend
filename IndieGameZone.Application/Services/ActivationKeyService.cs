using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestsAndResponses.Responses.ActivationKeys;
using MapsterMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace IndieGameZone.Application.Services
{
	internal sealed class ActivationKeyService : IActivationKeyService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly UserManager<Users> userManager;

		public ActivationKeyService(IRepositoryManager repositoryManager, IMapper mapper, UserManager<Users> userManager)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.userManager = userManager;
		}

		private async Task<bool> CheckGameOwnership(Guid userId, Guid gameId, CancellationToken ct = default)
		{
			var roles = await userManager.GetRolesAsync(await userManager.Users.AsNoTracking().SingleOrDefaultAsync(u => u.Id == userId, ct));
			var game = await repositoryManager.GameRepository.GetGameById(gameId, false, ct);
			if (roles.Contains(RoleEnum.Admin.ToString()) || roles.Contains(RoleEnum.Moderator.ToString()) || game.DeveloperId == userId)
			{
				return true;
			}
			var gameLibrary = await repositoryManager.LibraryRepository.GetLibraryByUserIdAndGameId(userId, gameId, false, ct);
			return gameLibrary != null;
		}

		private string GenerateRandomKey()
		{
			Random random = new Random();
			string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

			var sb = new StringBuilder();

			for (int g = 0; g < 5; g++)
			{
				if (g > 0) sb.Append('-');

				for (int i = 0; i < 5; i++)
				{
					sb.Append(chars[random.Next(chars.Length)]);
				}
			}

			return sb.ToString();
		}

		public async Task<IEnumerable<ActivationKeyForReturnDto>> GetKeyByGameId(Guid userId, Guid gameId, CancellationToken ct = default)
		{
			if (!await CheckGameOwnership(userId, gameId, ct))
			{
				throw new BadRequestException("You must own this game to see the activation key.");
			}
			var key = await repositoryManager.ActivationKeyRepository.GetByGameId(gameId, false, ct);
			return mapper.Map<IEnumerable<ActivationKeyForReturnDto>>(key);
		}

		public async Task ValidateActivationKey(Guid gameId, string activationKey, CancellationToken ct = default)
		{
			var key = await repositoryManager.ActivationKeyRepository.GetByKey(activationKey, true, ct);
			if (key == null) throw new NotFoundException("Key not found");
			if (key.GameId != gameId) throw new BadRequestException("Key does not belong to this game");
			if (!key.IsActive) throw new BadRequestException("Key has been deactivated");
			if (key.IsUsed) throw new BadRequestException("Key already used");
			key.IsUsed = true;
			await repositoryManager.SaveAsync(ct);
		}

		public async Task CreateActivationKey(Guid gameId, CancellationToken ct = default)
		{
			var keyEntity = new ActivationKeys()
			{
				Id = Guid.NewGuid(),
				GameId = gameId,
				IsUsed = false,
				IsActive = true,
				CreatedAt = DateTime.Now,
				Key = GenerateRandomKey()
			};
			repositoryManager.ActivationKeyRepository.Create(keyEntity);
			await repositoryManager.SaveAsync(ct);
		}

		public async Task ResetActivationKey(Guid userId, Guid gameId, CancellationToken ct = default)
		{
			var dbTransaction = await repositoryManager.BeginTransaction(ct);
			if (!await CheckGameOwnership(userId, gameId, ct))
			{
				throw new BadRequestException("You must own this game to reset the activation key.");
			}
			var order = await repositoryManager.OrderRepository.GetOrderByGameAndUser(gameId, userId, true, ct);
			if (order == null || order.ActivationKey == null)
			{
				throw new BadRequestException("You must have an order with an activation key to reset it.");
			}
			var oldKey = await repositoryManager.ActivationKeyRepository.GetByKey(order.ActivationKey.Key, true, ct);
			if (oldKey != null)
			{
				oldKey.IsActive = false;
			}
			var keyEntity = new ActivationKeys()
			{
				Id = Guid.NewGuid(),
				GameId = gameId,
				IsUsed = false,
				IsActive = true,
				CreatedAt = DateTime.Now,
				Key = GenerateRandomKey()
			};
			order.ActivationKey = keyEntity;
			repositoryManager.ActivationKeyRepository.Create(keyEntity);
			await repositoryManager.SaveAsync(ct);
			dbTransaction.Commit();
		}
	}
}
