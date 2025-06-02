using IndieGameZone.Domain.IRepositories;
using MapsterMapper;

namespace IndieGameZone.Application.PostCommentServices
{
	internal sealed class PostCommentService : IPostCommentService
	{
		private readonly IRepositoryManager repositoryManager;
		private readonly IMapper mapper;

		public PostCommentService(IRepositoryManager repositoryManager, IMapper mapper)
		{
			this.repositoryManager = repositoryManager;
			this.mapper = mapper;
		}

	}
}
