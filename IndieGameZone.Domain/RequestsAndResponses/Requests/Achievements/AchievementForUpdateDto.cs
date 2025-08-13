using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Achievements
{
	public class AchievementForUpdateDto
	{
		[Required]
		public string Name { get; init; }
		[Required]
		public string Image { get; init; }
	}
}
