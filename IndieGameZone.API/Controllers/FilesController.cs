using IndieGameZone.Application.IServices;
using Microsoft.AspNetCore.Authorization;
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
		[Authorize]
		public async Task<IActionResult> UploadImage(IFormFile file)
		{
			var result = await fileService.UploadScanFile(file);
			return Ok(result);
		}
	}
}
