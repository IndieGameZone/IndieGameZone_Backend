using IndieGameZone.Application.Hub;
using IndieGameZone.Application.IHub;
using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.WithdrawRequests;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Notifications;
using IndieGameZone.Domain.RequestsAndResponses.Responses.WithdrawRequests;
using MapsterMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Application.Services
{
	internal sealed class WithdrawRequestService : IWithdrawRequestService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly IBlobService blobService;
		private readonly UserManager<Users> userManager;
		private readonly IHubContext<NotificationHub, INotificationHub> notificationHub;

		public WithdrawRequestService(IRepositoryManager repositoryManager, IMapper mapper, IBlobService blobService, UserManager<Users> userManager, IHubContext<NotificationHub, INotificationHub> notificationHub)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.blobService = blobService;
			this.userManager = userManager;
			this.notificationHub = notificationHub;
		}
		public async Task CreateWithdrawRequest(Guid userId, WithdrawRequestForCreationDto withdrawRequestForCreationDto, CancellationToken ct = default)
		{
			var dbTransaction = await repositoryManager.BeginTransaction(ct);

			var firsttGame = await repositoryManager.GameRepository.GetFirstCreatedgameByuserId(userId, false, ct);
			var latestApproveWithdrawRequest = await repositoryManager.WithdrawRequestRepository.GetLatestApprovedWithdrawRequestByUserId(userId, false, ct);
			var daysSinceCreatedFirstGame = firsttGame != null ? (DateTime.Now - firsttGame.CreatedAt).Days : 0;
			if (latestApproveWithdrawRequest == null && (firsttGame == null || daysSinceCreatedFirstGame < 30))
			{
				throw new BadRequestException("You must upload at least one game and wait at least 30 days to make a withdraw request");
			}
			var daysSinceLatestApprovedWithdrawRequest = latestApproveWithdrawRequest != null ? (DateTime.Now - latestApproveWithdrawRequest.CreatedAt).Days : 0;
			if (latestApproveWithdrawRequest != null && daysSinceLatestApprovedWithdrawRequest < 30)
			{
				throw new BadRequestException("You can only make a withdraw request every 30 days");
			}

			var user = await userManager.Users.AsNoTracking().SingleOrDefaultAsync(u => u.Id == userId);
			if (user is null)
			{
				throw new NotFoundException("User not found");
			}
			var userProfile = await repositoryManager.UserProfileRepository.GetUserProfileById(userId, false, ct);
			if (string.IsNullOrEmpty(userProfile.BankAccountNumber) || string.IsNullOrEmpty(userProfile.BankAccountName))
			{
				throw new BadRequestException("Please complete your profile with bank account information before making a withdraw request");
			}
			var wallet = await repositoryManager.WalletRepository.GetWalletByUserId(userId, false, ct);
			if (withdrawRequestForCreationDto.Amount > wallet.Balance)
			{
				throw new BadRequestException("Insufficient balance in wallet");
			}

			var withdrawRequest = new WithdrawRequests
			{
				Id = Guid.NewGuid(),
				Status = WithdrawTransferStatus.Pending,
				Amount = withdrawRequestForCreationDto.Amount,
				CreatedAt = DateTime.Now,
				UserId = userId
			};

			repositoryManager.WithdrawRequestRepository.CreateWithdrawRequest(withdrawRequest);
			await repositoryManager.SaveAsync(ct);
			dbTransaction.Commit();
		}

		public async Task<(IEnumerable<WithdrawRequestForReturnDto> withdrawRequests, MetaData metaData)> GetWithdrawRequests(WithdrawRequestParameter withdrawRequestParameter, CancellationToken ct = default)
		{
			var withdrawRequestWithMetaData = await repositoryManager.WithdrawRequestRepository.GetWithdrawRequests(withdrawRequestParameter, false, ct);
			var withdrawRequests = mapper.Map<IEnumerable<WithdrawRequestForReturnDto>>(withdrawRequestWithMetaData);
			return (withdrawRequests, withdrawRequestWithMetaData.MetaData);
		}

		public async Task<(IEnumerable<WithdrawRequestForReturnDto> withdrawRequests, MetaData metaData)> GetWithdrawRequestsByUserId(Guid userId, WithdrawRequestParameter withdrawRequestParameter, CancellationToken ct = default)
		{
			var withdrawRequestWithMetaData = await repositoryManager.WithdrawRequestRepository.GetWithdrawRequestsByUserId(userId, withdrawRequestParameter, false, ct);
			var withdrawRequests = mapper.Map<IEnumerable<WithdrawRequestForReturnDto>>(withdrawRequestWithMetaData);
			return (withdrawRequests, withdrawRequestWithMetaData.MetaData);
		}

		public async Task UpdateWithdrawRequest(Guid id, WithdrawRequestForUpdateDto withdrawRequestForUpdateDto, CancellationToken ct = default)
		{
			var dbTransaction = await repositoryManager.BeginTransaction(ct);
			var withdrawRequest = await repositoryManager.WithdrawRequestRepository.GetWithdrawRequestById(id, true, ct);
			if (withdrawRequest is null)
			{
				throw new NotFoundException("Withdraw request not found");
			}
			mapper.Map(withdrawRequestForUpdateDto, withdrawRequest);
			withdrawRequest.HandledAt = DateTime.Now;
			if (withdrawRequestForUpdateDto.Status == WithdrawTransferStatus.Approved)
			{
				var wallet = await repositoryManager.WalletRepository.GetWalletByUserId(withdrawRequest.UserId, true, ct);
				var transaction = new Transactions
				{
					Id = Guid.NewGuid(),
					OrderCode = null,
					Amount = withdrawRequest.Amount,
					Description = "Withdraw money",
					Status = TransactionStatus.Success,
					Type = TransactionType.Withdraw,
					CreatedAt = DateTime.Now,
					UserId = withdrawRequest.UserId,
					PurchaseUserId = withdrawRequest.UserId,
					PaymentMethod = PaymentMethod.Wallet
				};
				var notification = new Notifications
				{
					Id = Guid.NewGuid(),
					UserId = withdrawRequest.UserId,
					Message = "Your withdraw request has been approved. Please check your bank account",
					CreatedAt = DateTime.Now,
					IsRead = false
				};
				wallet.Balance -= withdrawRequest.Amount;
				repositoryManager.TransactionRepository.CreateTransaction(transaction);
				repositoryManager.NotificationRepository.CreateNotification(notification);
				await notificationHub.Clients.User(withdrawRequest.UserId.ToString()).SendNotification(new NotificationForReturnDto
				{
					Id = notification.Id,
					Message = notification.Message,
					CreatedAt = notification.CreatedAt,
					IsRead = notification.IsRead,
					ReadAt = notification.ReadAt
				});
			}
			else if (withdrawRequestForUpdateDto.Status == WithdrawTransferStatus.Rejected)
			{
				var notification = new Notifications
				{
					Id = Guid.NewGuid(),
					UserId = withdrawRequest.UserId,
					Message = "Your withdraw request has been rejected",
					CreatedAt = DateTime.Now,
					IsRead = false
				};
				repositoryManager.NotificationRepository.CreateNotification(notification);
				await notificationHub.Clients.User(withdrawRequest.UserId.ToString()).SendNotification(new NotificationForReturnDto
				{
					Id = notification.Id,
					Message = notification.Message,
					CreatedAt = notification.CreatedAt,
					IsRead = notification.IsRead,
					ReadAt = notification.ReadAt
				});
			}

			await repositoryManager.SaveAsync(ct);
			dbTransaction.Commit();
		}
	}
}
