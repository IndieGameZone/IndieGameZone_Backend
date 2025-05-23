using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Tags
{
	public class TagForUpdateDto
	{
		[Required]
		public string Name { get; init; }
	}
}
