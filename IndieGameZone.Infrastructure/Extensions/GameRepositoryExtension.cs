using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.Entities;

namespace IndieGameZone.Infrastructure.Extensions
{
	public static class GameRepositoryExtension
	{
		public static IQueryable<Games> Sort(this IQueryable<Games> source)
		{
			return source.OrderByDescending(x => x.CreatedAt);
		}

		public static IQueryable<Games> Search(this IQueryable<Games> source, string? searchTerm)
		{
			if (string.IsNullOrWhiteSpace(searchTerm))
			{
				return source;
			}
			return source.Where(x => x.Name.ToLower().Contains(searchTerm.ToLower()));
		}

		public static IQueryable<Games> FilterByCensorStatus(this IQueryable<Games> source, CensorStatus? censorStatus)
		{
			if (censorStatus == null)
			{
				return source;
			}
			return source.Where(x => x.CensorStatus == censorStatus);
		}

		public static IQueryable<Games> FilterByPrice(this IQueryable<Games> source, string? price)
		{
			double priceValue;
			if (string.IsNullOrEmpty(price) || !double.TryParse(price, out priceValue))
			{
				return source;
			}
			return source.Where(x => x.Price <= priceValue);
		}

		public static IQueryable<Games> FilterByTags(this IQueryable<Games> source, ICollection<Guid> tags)
		{
			if (tags == null || !tags.Any())
			{
				return source;
			}
			return source.Where(x => x.GameTags.Any(gt => tags.Contains(gt.TagId)));
		}

		public static IQueryable<Games> FilterByPlatform(this IQueryable<Games> source, ICollection<Guid> platforms)
		{
			if (platforms == null || !platforms.Any())
			{
				return source;
			}
			return source.Where(x => x.GamePlatforms.Any(gp => platforms.Contains(gp.PlatformId)));
		}

		public static IQueryable<Games> FilterByLanguages(this IQueryable<Games> source, ICollection<Guid> languages)
		{
			if (languages == null || !languages.Any())
			{
				return source;
			}
			return source.Where(x => x.GameLanguages.Any(gl => languages.Contains(gl.LanguageId)));
		}
	}
}
