using Microsoft.AspNetCore.Http;

namespace IndieGameZone.Application.IServices
{
	public interface IFileService
	{
		Task<string> UploadScanFile(IFormFile file, CancellationToken ct = default);
	}
}
