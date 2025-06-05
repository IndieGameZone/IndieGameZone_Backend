using IndieGameZone.Application.BlobService;
using IndieGameZone.Domain.Constants;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class ImagesController : ControllerBase
	{
		private readonly IBlobService blobService;

		public ImagesController(IBlobService blobService)
		{
			this.blobService = blobService;
		}

		[HttpPost("images")]
		public async Task<IActionResult> UploadImage(IFormFile image)
		{
			if (image == null || image.Length == 0)
			{
				return BadRequest("No file uploaded.");
			}
			var uploadedUrl = await blobService.UploadBlob(
						$"{Guid.NewGuid()}{Path.GetExtension(image.FileName)}",
						StorageContainer.STORAGE_CONTAINER,
						image);

			return Ok(uploadedUrl);
		}
	}
}
