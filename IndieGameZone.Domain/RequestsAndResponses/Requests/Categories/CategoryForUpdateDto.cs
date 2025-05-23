using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Categories
{
	public class CategoryForUpdateDto
	{
		[Required]
		public string Name { get; init; }
	}
}
