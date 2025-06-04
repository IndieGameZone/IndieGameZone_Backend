using System.Data;

namespace IndieGameZone.Domain.IRepositories
{
	public interface IRepositoryManager
	{
		Task SaveAsync(CancellationToken ct = default);
		Task<IDbTransaction> BeginTransaction(CancellationToken ct = default);
		ILanguageRepository LanguageRepository { get; }
		ITagRepository TagRepository { get; }
		ICategoryRepository CategoryRepository { get; }
		IPlatformRepository PlatformRepository { get; }
		IAgeRestrictionRepository AgeRestrictionRepository { get; }
		IGameRepository GameRepository { get; }
		IAchievementRepository AchievementRepository { get; }
		IUserRepository UserRepository { get; }
		IUserProfileRepository UserProfileRepository { get; }
		IWalletRepository WalletRepository { get; }
		IGamePlatformRepository GamePlatformRepository { get; }
		IGameImageRepository GameImageRepository { get; }
		IGameLanguageRepository GameLanguageRepository { get; }
		IGameTagRepository GameTagRepository { get; }
		IDiscountRepository DiscountRepository { get; }
		IWishlistRepository WishlistRepository { get; }
		ITransactionRepository TransactionRepository { get; }
		IReviewRepository ReviewRepository { get; }
		ILibraryRepository LibraryRepository { get; }
		IWithdrawRequestRepository WithdrawRequestRepository { get; }
		IPostRepository PostRepository { get; }
		IPostCommentRepository PostCommentRepository { get; }
        ICommercialPackageRepository CommercialPackageRepository { get; }
    }
}
