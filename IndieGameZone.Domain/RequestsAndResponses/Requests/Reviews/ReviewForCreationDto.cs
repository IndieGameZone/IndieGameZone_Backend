using System.ComponentModel.DataAnnotations;

namespace IndieGameZone.Domain.RequestsAndResponses.Requests.Reviews
{
	public class ReviewForCreationDto
	{
		[Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
		[Required]
		public double Rating { get; init; }
		[Required]
		public string Comment { get; init; }
	}
}
