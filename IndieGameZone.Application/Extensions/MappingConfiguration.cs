using IndieGameZone.Domain.Entities;
using IndieGameZone.Domain.RequestsAndResponses.Requests.Games;
using IndieGameZone.Domain.RequestsAndResponses.Responses.BanHistories;
using IndieGameZone.Domain.RequestsAndResponses.Responses.CommercialPackages;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Games;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Posts;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Reports;
using IndieGameZone.Domain.RequestsAndResponses.Responses.Users;
using Mapster;

namespace IndieGameZone.Application.Extensions
{
	public class MappingConfiguration : IRegister
	{
		public void Register(TypeAdapterConfig config)
		{
			config.NewConfig<Posts, PostForReturnDto>()
				.Map(dest => dest.NumberOfComments, src => src.PostComments.Count)
				.Map(dest => dest.NumberOfLikes, src => src.PostReactions.Count);

			config.NewConfig<GameForCreationDto, Games>()
				.Ignore(dest => dest.GameImages);
			config.NewConfig<GameForUpdateDto, Games>()
				.Ignore(dest => dest.GameImages);

			config.NewConfig<Games, GameForListReturnDto>()
				.Map(dest => dest.AverageRating, src => src.Reviews.Any() ? src.Reviews.Average(r => r.Rating) : 0)
				.Map(dest => dest.NumberOfReviews, src => src.Reviews.Count)
				.Map(dest => dest.Discount, src => src.Discounts.Any() ? src.Discounts.Where(d => DateOnly.FromDateTime(DateTime.Now) <= d.EndDate).Select(d => d.Percentage).FirstOrDefault() : 0);

			config.NewConfig<Games, GameForSingleReturnDto>()
				.Map(dest => dest.AverageRating, src => src.Reviews.Any() ? src.Reviews.Average(r => r.Rating) : 0)
				.Map(dest => dest.NumberOfReviews, src => src.Reviews.Count)
				.Map(dest => dest.Discount, src => src.Discounts.Any() ? src.Discounts.Where(d => DateOnly.FromDateTime(DateTime.Now) <= d.EndDate).Select(d => d.Percentage).FirstOrDefault() : 0);

			config.NewConfig<Games, GameForRecommendationDto>()
				.Map(dest => dest.Category, src => src.Category.Name)
				.Map(dest => dest.Tags, src => src.GameTags.Select(gt => gt.Tag.Name).ToList());

            config.NewConfig<Users, UserForReturnDto>()
				.Map(dest => dest.Fullname, src => src.UserProfile.Fullname)
				.Map(dest => dest.Avatar, src => src.UserProfile.Avatar)
				.Map(dest => dest.Bio, src => src.UserProfile.Bio)
				.Map(dest => dest.Birthday, src => src.UserProfile.Birthday)
				.Map(dest => dest.YoutubeChannelLink, src => src.UserProfile.YoutubeChannelLink)
				.Map(dest => dest.FacebookLink, src => src.UserProfile.FacebookLink)
				.Map(dest => dest.BankAccountNumber, src => src.UserProfile.BankAccountNumber)
				.Map(dest => dest.BankAccountName, src => src.UserProfile.BankAccountName)
				.Map(dest => dest.Balance, src => src.Wallet.Balance)
                .Map(dest => dest.BankInfo, src => src.UserProfile.Adapt<BankInfoForReturnDto>());

			config.NewConfig<Users, UserShortForReturnDto>()
				.Map(dest => dest.Fullname, src => src.UserProfile.Fullname)
				.Map(dest => dest.Avatar, src => src.UserProfile.Avatar)
				.Map(dest => dest.BankAccountNumber, src => src.UserProfile.BankAccountNumber)
				.Map(dest => dest.BankAccountName, src => src.UserProfile.BankAccountName);

            config.NewConfig<BanHistories, BanHistoryForReturnDto>()
				.Map(dest => dest.BannedUser, src => src.BannedUser)
				.Map(dest => dest.BannedByUser, src => src.BannedByUser);

			config.NewConfig<CommercialRegistrations, CommercialRegistrationForReturnDto>()
				.Map(dest => dest.GameName, src => src.Game.Name)
				.Map(dest => dest.CommercialPackageName, src => src.CommercialPackage.Name)
				.Map(dest => dest.Price, src => src.CommercialPackage.Price)
				.Map(dest => dest.Duration, src => src.CommercialPackage.Duration)
				.Map(dest => dest.Developer, src => src.Game.Developer);

			config.NewConfig<Users, UserReportForReturnDto>()
				.Map(dest => dest.Fullname, src => src.UserProfile.Fullname)
				.Map(dest => dest.Avatar, src => src.UserProfile.Avatar);


            config.NewConfig<Reports, ReportForReturnDto>()
				.Map(dest => dest.Id, src => src.Id)
				.Map(dest => dest.Message, src => src.Message)
				.Map(dest => dest.CreatedAt, src => src.CreatedAt)
				.Map(dest => dest.Status, src => src.Status)
				.Map(dest => dest.ReviewMessage, src => src.ReviewMessage)
				.Map(dest => dest.ReportReason, src => src.ReportReason)
				.Map(dest => dest.ReportingUser, src => src.ReportingUser)
				.Map(dest => dest.Post, src => src.Post)
				.Map(dest => dest.Game, src => src.Game)
				.Map(dest => dest.PostComment, src => src.PostComment);

			config.NewConfig<Reports, GameReportForReturnDto>()
				.Map(dest => dest.Id, src => src.Id)
				.Map(dest => dest.Message, src => src.Message)
				.Map(dest => dest.CreatedAt, src => src.CreatedAt)
                .Map(dest => dest.UpdatedAt, src => src.UpdatedAt)
                .Map(dest => dest.Status, src => src.Status)
				.Map(dest => dest.ReviewMessage, src => src.ReviewMessage)
				.Map(dest => dest.ReportReason, src => src.ReportReason)
				.Map(dest => dest.ReportingUser, src => src.ReportingUser)
                .Map(dest => dest.GameOwner, src => src.Game.Developer)
                .Map(dest => dest.Game, src => src.Game);

			config.NewConfig<Reports, PostReportForReturnDto>()
				.Map(dest => dest.Id, src => src.Id)
				.Map(dest => dest.Message, src => src.Message)
				.Map(dest => dest.CreatedAt, src => src.CreatedAt)
                .Map(dest => dest.UpdatedAt, src => src.UpdatedAt)
				.Map(dest => dest.Status, src => src.Status)
                .Map(dest => dest.ReviewMessage, src => src.ReviewMessage)
				.Map(dest => dest.ReportReason, src => src.ReportReason)
				.Map(dest => dest.ReportingUser, src => src.ReportingUser)
                .Map(dest => dest.PostOwner, src => src.Post.User)
                .Map(dest => dest.Post, src => src.Post)
                .Map(dest => dest.GameId, src => src.GameId)
                .Map(dest => dest.GameName, src => src.Game.Name);

			config.NewConfig<Reports, CommentReportForReturnDto>()
				.Map(dest => dest.Id, src => src.Id)
				.Map(dest => dest.Message, src => src.Message)
				.Map(dest => dest.CreatedAt, src => src.CreatedAt)
                .Map(dest => dest.UpdatedAt, src => src.UpdatedAt)
				.Map(dest => dest.Status, src => src.Status)
                .Map(dest => dest.ReviewMessage, src => src.ReviewMessage)
				.Map(dest => dest.ReportReason, src => src.ReportReason)
				.Map(dest => dest.ReportingUser, src => src.ReportingUser)
				.Map(dest => dest.CommentOwner, src => src.PostComment.User)
				.Map(dest => dest.PostComment, src => src.PostComment)
				.Map(dest => dest.GameId, src => src.GameId)
				.Map(dest => dest.GameName, src => src.Game.Name)
				.Map(dest => dest.PostId, src => src.PostId)
				.Map(dest => dest.PostTitle, src => src.Post.Title);

        }
    }
}
