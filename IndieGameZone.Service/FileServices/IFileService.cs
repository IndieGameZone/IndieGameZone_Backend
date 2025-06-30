using Microsoft.AspNetCore.Http;

namespace IndieGameZone.Application.FileServices
{
	public interface IFileService
	{
		Task<string> UploadScanFile(IFormFile file);
	}
}
