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

		public FilesController(IBlobService blobService)
		{
			this.blobService = blobService;
		}

		[HttpPost("files")]
		public async Task<IActionResult> UploadImage(IFormFile file)
		{
			if (file == null || file.Length == 0)
			{
				return BadRequest("No file uploaded.");
			}
			var uploadedUrl = await blobService.UploadBlob(
						$"{file.Name}{Path.GetExtension(file.FileName)}",
						StorageContainer.STORAGE_CONTAINER,
						file);

			return Ok(uploadedUrl);
		}
	}
}
