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

		[HttpPost("transactions/deposit")]
		public async Task<IActionResult> CreateTransactionForDeposit([FromBody] TransactionForCreationDto transaction, CancellationToken ct)
		{
			var result = await serviceManager.TransactionService.CreateTransactionForDeposit(transaction, ct);
			return StatusCode(201, result);
		}

		[HttpPost("transactions/purchase")]
		public async Task<IActionResult> CreateTransactionForPurchase([FromBody] TransactionForCreationDto transaction, CancellationToken ct)
		{
			await serviceManager.TransactionService.CreateTransactionForPurchase(transaction, ct);
			return StatusCode(201);
		}

		public record Responses(int error, string message, object? data);

		[HttpPost("transactions/hook-receiving")]
		public async Task<IActionResult> IPN([FromBody] WebhookType webhookBody, CancellationToken ct)
		{
			var clientId = configuration.GetSection("PayOSClientID").Value;
			var apiKey = configuration.GetSection("PayOSAPIKey").Value;
			var checksumKey = configuration.GetSection("PayOSChecksumKey").Value;

			var payOS = new PayOS(clientId, apiKey, checksumKey);
			WebhookData data = payOS.verifyPaymentWebhookData(webhookBody);

			await serviceManager.TransactionService.IPNAsync(data, ct);
			return Ok(new Responses(0, "Success", null));
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
