
using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace IndieGameZone.Application.PostReactionServices
{
	internal sealed class PostReactionService : IPostReactionService
	{
		private readonly IRepositoryManager repositoryManager;

		public PostReactionService(IRepositoryManager repositoryManager)
		{
			this.repositoryManager = repositoryManager;
		}
		public async Task CreateOrDeleteReactions(Guid userId, Guid postId, CancellationToken ct = default)
		{
			var reaction = await repositoryManager.PostReactionRepository.GetReaction(userId, postId, false, ct);
			if (reaction == null)
			{
				repositoryManager.PostReactionRepository.CreateReactions(new PostReactions { PostId = postId, UserId = userId });
			}
			else
			{
				repositoryManager.PostReactionRepository.DeleteReactions(reaction);
			}
			await repositoryManager.SaveAsync(ct);
		}

		public Task<int> GetNumberOfLikesByPostId(Guid postId, CancellationToken ct = default)
		{
			return repositoryManager.PostReactionRepository.GetReactionsByPostId(postId, false, ct).CountAsync();
		}

		public async Task<bool> IsPostLikedByUser(Guid userId, Guid postId, CancellationToken ct = default)
		{
			var reaction = await repositoryManager.PostReactionRepository.GetReaction(userId, postId, false, ct);
			return reaction != null;
		}
	}
}
