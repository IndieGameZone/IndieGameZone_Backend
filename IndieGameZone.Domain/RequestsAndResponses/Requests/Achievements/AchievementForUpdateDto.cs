using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Achievements
{
	public class AchievementForUpdateDto
	{
		[Required]
		public required string Name { get; init; }
	}
}
