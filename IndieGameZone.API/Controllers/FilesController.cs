using IndieGameZone.Application.FileServices;
using Microsoft.AspNetCore.Mvc;

namespace IndieGameZone.API.Controllers
{
	[Route("api")]
	[ApiController]
	public class FilesController : ControllerBase
	{
		private readonly IFileService fileService;

		public FilesController(IFileService fileService)
		{
			this.fileService = fileService;
		}


		[HttpPost("files")]
		public async Task<IActionResult> UploadImage(IFormFile file)
		{
			return Ok(await fileService.UploadScanFile(file));
		}
	}
}
