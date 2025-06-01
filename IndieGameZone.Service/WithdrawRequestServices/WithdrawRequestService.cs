using IndieGameZone.Application.BlobService;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.Exceptions;
using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.WithdrawRequests;
using IndieGameZone.Domain.RequestsAndResponses.Responses.WithdrawRequests;
using MapsterMapper;
using Microsoft.AspNetCore.Http;

namespace IndieGameZone.Application.WithdrawRequestServices
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
			Random random = new Random();
			var transaction = new Transactions
			{
				Id = Guid.NewGuid(),
				OrderCode = random.Next(100000, 999999),
				Amount = withdrawRequestForCreationDto.Amount,
				Description = withdrawRequestForCreationDto.Description ?? string.Empty,
				Status = Domain.Constants.TransactionStatus.Pending,
				Type = Domain.Constants.TransactionType.Withdraw,
				CreatedAt = DateTime.Now,
				UserId = userId
			};

			var withdrawRequest = new WithdrawRequests
			{
				TransactionId = transaction.Id,
				IsTransfered = false,
				CreatedAt = DateTime.Now,
				ImageProof = string.Empty,
			};

			repositoryManager.TransactionRepository.CreateTransaction(transaction);
			repositoryManager.WithdrawRequestRepository.CreateWithdrawRequest(withdrawRequest);
			await repositoryManager.SaveAsync(ct);
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

		public async Task UpdateWithdrawRequest(Guid transactionId, IFormFile imageProof, CancellationToken ct = default)
		{
			var withdrawRequest = await repositoryManager.WithdrawRequestRepository.GetWithdrawRequestByTransactionId(transactionId, true, ct);
			if (withdrawRequest is null)
			{
				throw new NotFoundException("Withdraw request not found");
			}
			string fileName = $"{transactionId}_{DateTime.Now:yyyyMMddHHmmssfff}{Path.GetExtension(imageProof.FileName)}";
			withdrawRequest.ImageProof = await blobService.UploadBlob(fileName, StorageContainer.STORAGE_CONTAINER, imageProof);
			withdrawRequest.IsTransfered = true;
			await repositoryManager.SaveAsync(ct);
		}
	}
}
