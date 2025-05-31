using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Domain.RequestFeatures;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Libraries;
using MapsterMapper;

namespace IndieGameZone.Application.LibraryServices
{
	internal sealed class LibraryService : ILibraryService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public LibraryService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}

		public async Task<(IEnumerable<LibraryForReturnDto> libraries, MetaData metaData)> GetLibrariesByUserId(Guid userId, LibraryParameters libraryParameters, CancellationToken ct = default)
		{
			var libraryWithMetaData = await repositoryManager.LibraryRepository.GetLibraryByUserId(userId, libraryParameters, false, ct);
			var libraries = mapper.Map<IEnumerable<LibraryForReturnDto>>(libraryWithMetaData);
			return (libraries, libraryWithMetaData.MetaData);
		}
	}
}
