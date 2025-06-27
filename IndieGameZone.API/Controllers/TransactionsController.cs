using IndieGameZone.Application;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Transactions;
using Microsoft.AspNetCore.Mvc;
using Net.payOS;
using Net.payOS.Types;
using System.Text.Json;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class TransactionsController : ControllerBase
	{
		private readonly IServiceManager serviceManager;
		private readonly IConfiguration configuration;

		public TransactionsController(IServiceManager serviceManager, IConfiguration configuration)
		{
			this.serviceManager = serviceManager;
			this.configuration = configuration;
		}

		[HttpPost("users/{userId:guid}/transactions/deposit")]
		public async Task<IActionResult> CreateTransactionForDeposit([FromRoute] Guid userId, [FromBody] TransactionForDepositCreationDto transaction, CancellationToken ct)
		{
			var result = await serviceManager.TransactionService.CreateTransactionForDeposit(userId, transaction, ct);
			return StatusCode(201, result);
		}

		[HttpPost("users/{userId:guid}/games/{gameId:guid}/transactions/game-wallet-purchasing")]
		public async Task<IActionResult> CreateTransactionForPurchase([FromRoute] Guid userId, [FromRoute] Guid gameId, [FromQuery] string? couponCode, CancellationToken ct)
		{
			await serviceManager.TransactionService.CreateTransactionForGameWalletPurchase(userId, gameId, couponCode, ct);
			return StatusCode(201);
		}

		[HttpPost("users/{userId:guid}/games/{gameId:guid}/transactions/game-payos-purchasing")]
		public async Task<IActionResult> CreateTransactionForPayOSPurchase([FromRoute] Guid userId, [FromRoute] Guid gameId, [FromQuery] string? couponCode, CancellationToken ct)
		{
			var result = await serviceManager.TransactionService.CreateTransactionForGamePayOSPurchase(userId, gameId, couponCode, ct);
			return StatusCode(201, result);
		}

		[HttpPost("users/{userId:guid}/games/{gameId:guid}/transactions/donation")]
		public async Task<IActionResult> CreateTransactionForDonation([FromRoute] Guid userId, [FromRoute] Guid gameId, [FromBody] TransactionForDonationCreationDto transactionForDonationCreationDto, CancellationToken ct)
		{
			var result = await serviceManager.TransactionService.CreateTransactionForDonation(userId, gameId, transactionForDonationCreationDto, ct);
			return StatusCode(201, result);
		}


		[HttpPost("transactions/hook-receiving")]
		public async Task<IActionResult> IPN([FromBody] WebhookType webhookBody, CancellationToken ct)
		{
			var clientId = configuration.GetSection("PayOSClientID").Value;
			var apiKey = configuration.GetSection("PayOSAPIKey").Value;
			var checksumKey = configuration.GetSection("PayOSChecksumKey").Value;

			var payOS = new PayOS(clientId, apiKey, checksumKey);
			WebhookData data = payOS.verifyPaymentWebhookData(webhookBody);

			await serviceManager.TransactionService.IPNAsync(data, ct);
			return Ok();
		}

		[HttpGet("users/{userId}/transactions")]
		public async Task<IActionResult> GetTransactionsByUserId(Guid userId, [FromQuery] TransactionParameters transactionParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.TransactionService.GetTransactionsByUserId(userId, transactionParameters, false, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.transactions);
		}

		[HttpGet("transactions")]
		public async Task<IActionResult> GetTransactions([FromQuery] TransactionParameters transactionParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.TransactionService.GetTransactions(transactionParameters, false, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.transactions);
		}
	}
}
