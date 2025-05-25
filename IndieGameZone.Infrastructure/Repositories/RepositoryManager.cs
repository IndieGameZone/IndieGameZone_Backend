using IndieGameZone.Domain.IRepositories;
using IndieGameZone.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;

namespace IndieGameZone.Infrastructure.Repositories
{
	public sealed class RepositoryManager : IRepositoryManager
	{
		private readonly AppDbContext appDbContext;
		private readonly Lazy<ILanguageRepository> languageRepository;
		private readonly Lazy<ITagRepository> tagRepository;
		private readonly Lazy<ICategoryRepository> categoryRepository;
		private readonly Lazy<IPlatformRepository> platformRepository;
		private readonly Lazy<IGameStatusRepository> gameStatusRepository;
		private readonly Lazy<IAgeRestrictionRepository> ageRestrictionRepository;
		private readonly Lazy<IGameRepository> gameRepository;
		private readonly Lazy<IAchievementRepository> achievementRepository;
		private readonly Lazy<IUserRepository> userRepository;
		private readonly Lazy<IUserProfileRepository> userProfileRepository;
		private readonly Lazy<IWalletRepository> walletRepository;
		private readonly Lazy<IGamePlatformRepository> gamePlatformRepository;
		private readonly Lazy<IGameInfoRepository> gameInfoRepository;
		private readonly Lazy<IGameLanguageRepository> gameLanguageRepository;
		private readonly Lazy<IGameTagRepository> gameTagRepository;
		private readonly Lazy<IDiscountRepository> discountRepository;

		public RepositoryManager(AppDbContext appDbContext)
		{
			this.appDbContext = appDbContext;
			languageRepository = new Lazy<ILanguageRepository>(() => new LanguageRepository(appDbContext));
			tagRepository = new Lazy<ITagRepository>(() => new TagRepository(appDbContext));
			categoryRepository = new Lazy<ICategoryRepository>(() => new CategoryRepository(appDbContext));
			platformRepository = new Lazy<IPlatformRepository>(() => new PlatformRepository(appDbContext));
			gameStatusRepository = new Lazy<IGameStatusRepository>(() => new GameStatusRepository(appDbContext));
			ageRestrictionRepository = new Lazy<IAgeRestrictionRepository>(() => new AgeRestrictionRepository(appDbContext));
			gameRepository = new Lazy<IGameRepository>(() => new GameRepository(appDbContext));
			achievementRepository = new Lazy<IAchievementRepository>(() => new AchievementRepository(appDbContext));
			userRepository = new Lazy<IUserRepository>(() => new UserRepository(appDbContext));
			userProfileRepository = new Lazy<IUserProfileRepository>(() => new UserProfileRepository(appDbContext));
			walletRepository = new Lazy<IWalletRepository>(() => new WalletRepository(appDbContext));
			gamePlatformRepository = new Lazy<IGamePlatformRepository>(() => new GamePlatformRepository(appDbContext));
			gameInfoRepository = new Lazy<IGameInfoRepository>(() => new GameInfoRepository(appDbContext));
			gameLanguageRepository = new Lazy<IGameLanguageRepository>(() => new GameLanguageRepository(appDbContext));
			gameTagRepository = new Lazy<IGameTagRepository>(() => new GameTagRepository(appDbContext));
			discountRepository = new Lazy<IDiscountRepository>(() => new DiscountRepository(appDbContext));
		}

		public ILanguageRepository LanguageRepository => languageRepository.Value;

		public ITagRepository TagRepository => tagRepository.Value;

		public ICategoryRepository CategoryRepository => categoryRepository.Value;

		public IPlatformRepository PlatformRepository => platformRepository.Value;

		public IGameStatusRepository GameStatusRepository => gameStatusRepository.Value;

		public IAgeRestrictionRepository AgeRestrictionRepository => ageRestrictionRepository.Value;

		public IGameRepository GameRepository => gameRepository.Value;

		public IAchievementRepository AchievementRepository => achievementRepository.Value;

		public IUserRepository UserRepository => userRepository.Value;

		public IUserProfileRepository UserProfileRepository => userProfileRepository.Value;

		public IWalletRepository WalletRepository => walletRepository.Value;
		public IGamePlatformRepository GamePlatformRepository => gamePlatformRepository.Value;

		public IGameInfoRepository GameInfoRepository => gameInfoRepository.Value;

		public IGameLanguageRepository GameLanguageRepository => gameLanguageRepository.Value;

		public IGameTagRepository GameTagRepository => gameTagRepository.Value;

		public IDiscountRepository DiscountRepository => discountRepository.Value;

        public async Task<IDbTransaction> BeginTransaction(CancellationToken ct = default)
		{
			var transaction = await appDbContext.Database.BeginTransactionAsync(ct);
			return transaction.GetDbTransaction();
		}

		public Task SaveAsync(CancellationToken ct = default) => appDbContext.SaveChangesAsync(ct);

	} 
}
