using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Categories
{
	public class CategoryForCreationDto
	{
		[Required]
		public string Name { get; init; }
	}
}
