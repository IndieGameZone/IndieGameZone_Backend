using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.WithdrawRequests;
using IndieGameZone.Domain.RequestsAndResponses.Responses.WithdrawRequests;
using MapsterMapper;

namespace IndieGameZone.Application.Services
{
	internal sealed class WithdrawRequestService : IWithdrawRequestService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;
		private readonly IBlobService blobService;

		public WithdrawRequestService(IRepositoryManager repositoryManager, IMapper mapper, IBlobService blobService)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
			this.blobService = blobService;
		}
		public async Task CreateWithdrawRequest(Guid userId, WithdrawRequestForCreationDto withdrawRequestForCreationDto, CancellationToken ct = default)
		{
			var dbTransaction = await repositoryManager.BeginTransaction(ct);
			var userProfile = await repositoryManager.UserProfileRepository.GetUserProfileById(userId, false, ct);
			if (string.IsNullOrEmpty(userProfile.BankAccount) || string.IsNullOrEmpty(userProfile.BankName))
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
					Description = string.Empty,
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
			}

			await repositoryManager.SaveAsync(ct);
			dbTransaction.Commit();
		}
	}
}
