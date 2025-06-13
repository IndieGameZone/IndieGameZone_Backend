using IndieGameZone.Application.AIService;
using IndieGameZone.Application.BlobService;
using IndieGameZone.Domain.Constants;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class FilesController : ControllerBase
	{
		private readonly IBlobService blobService;
		private readonly IAIService aIService;

		public FilesController(IBlobService blobService, IAIService aIService)
		{
			this.blobService = blobService;
			this.aIService = aIService;
		}

		[HttpPost("files")]
		public async Task<IActionResult> UploadImage(IFormFile file)
		{
			if (file == null || file.Length == 0)
			{
				return BadRequest("No file uploaded.");
			}
			var uploadedUrl = await blobService.UploadBlob(
						$"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}",
						StorageContainer.STORAGE_CONTAINER,
						file);
			if (file.FileName.EndsWith(".jpg") || file.FileName.EndsWith(".png"))
			{
				if (!await aIService.AnalyzeImage(uploadedUrl))
				{
					return BadRequest("Image analysis failed. Please ensure the image is appropriate.");
				}
			}
			if (file.FileName.EndsWith(".rar") || file.FileName.EndsWith(".zip") || file.FileName.EndsWith(".exe"))
			{

			}

			return Ok(uploadedUrl);
		}
	}
}
