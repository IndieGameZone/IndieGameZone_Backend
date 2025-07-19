using IndieGameZone.Domain.Constants;
using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Tags
{
	public class TagForUpdateDto
	{
		[Required]
		public string Name { get; init; }
		[Required]
		public TagTypeEnum Type { get; init; }
	}
}
