using IndieGameZone.Application;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Transactions;
using Microsoft.AspNetCore.Authorization;
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
		[Authorize(Roles = $"{nameof(RoleEnum.Player)}")]
		public async Task<IActionResult> CreateTransactionForDeposit([FromRoute] Guid userId, [FromBody] TransactionForDepositCreationDto transaction, CancellationToken ct)
		{
			var paymentLink = await serviceManager.TransactionService.CreateTransactionForDeposit(userId, transaction, ct);
			return StatusCode(201, paymentLink);
		}

		[HttpPost("users/{userId:guid}/games/{gameId:guid}/transactions/game-purchasing")]
		[Authorize(Roles = $"{nameof(RoleEnum.Player)}")]
		public async Task<IActionResult> CreateTransactionForPurchase([FromRoute] Guid userId, [FromRoute] Guid gameId, [FromForm] TransactionForGameCreation transactionForGameCreation, CancellationToken ct)
		{
			var paymentLink = await serviceManager.TransactionService.CreateTransactionForGamePurchase(userId, gameId, transactionForGameCreation, ct);
			return StatusCode(201, paymentLink);
		}

		[HttpPost("users/{userId:guid}/games/{gameId:guid}/transactions/donation")]
		[Authorize(Roles = $"{nameof(RoleEnum.Player)}")]
		public async Task<IActionResult> CreateTransactionForDonation([FromRoute] Guid userId, [FromRoute] Guid gameId, [FromBody] TransactionForDonationCreationDto transactionForDonationCreationDto, CancellationToken ct)
		{
			var result = await serviceManager.TransactionService.CreateTransactionForDonation(userId, gameId, transactionForDonationCreationDto, ct);
			return StatusCode(201, result);
		}

		/// <summary>
		/// Update transaction as cancel. Call when navigating when the user cancels the payment.
		/// </summary>
		[HttpPut("transactions/{orderCode:long}/cancel")]
		public async Task<IActionResult> CancelTransaction([FromRoute] long orderCode, CancellationToken ct)
		{
			await serviceManager.TransactionService.Cancel(orderCode, ct);
			return NoContent();
		}

		[HttpPost("users/{userId:guid}/games/{gameId:guid}/commercial-packages/{commercialPackageId:guid}/transactions/commercial-purchasing")]
		[Authorize(Roles = $"{nameof(RoleEnum.Developer)}")]
		public async Task<IActionResult> CreateTransactionForCommercialPurchase([FromRoute] Guid userId, [FromRoute] Guid gameId, [FromRoute] Guid commercialPackageId, [FromBody] TransactionForCommercialDto dto, CancellationToken ct)
		{
			var result = await serviceManager.TransactionService.CreateTransactionForCommercialPurchase(userId, gameId, commercialPackageId, dto, ct);
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

			Console.WriteLine($"Webhook received: {JsonSerializer.Serialize(webhookBody)}");

			await serviceManager.TransactionService.IPNAsync(data, webhookBody.success, ct);
			return Ok();
		}

		[HttpGet("users/{userId}/transactions")]
		[Authorize]
		public async Task<IActionResult> GetTransactionsByUserId(Guid userId, [FromQuery] TransactionParameters transactionParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.TransactionService.GetTransactionsByUserId(userId, transactionParameters, false, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.transactions);
		}

		[HttpGet("transactions")]
		[Authorize(Roles = $"{nameof(RoleEnum.Admin)}")]
		public async Task<IActionResult> GetTransactions([FromQuery] TransactionParameters transactionParameters, CancellationToken ct)
		{
			var pagedResult = await serviceManager.TransactionService.GetTransactions(transactionParameters, false, ct);
			Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metaData));
			return Ok(pagedResult.transactions);
		}
	}
}
