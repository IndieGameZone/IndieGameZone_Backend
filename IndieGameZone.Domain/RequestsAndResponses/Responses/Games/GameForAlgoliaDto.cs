namespace IndieGameZone.Domain.RequestsAndResponses.Responses.Games
{
	public class GameForAlgoliaDto
	{
		public Guid ObjectID { get; set; }
		public string Name { get; set; }
		public string CoverImage { get; set; }
		public string ShortDescription { get; set; }
		public double Price { get; set; }
		public string Category { get; set; }
		public ICollection<string> Tags { get; set; } = new List<string>();
	}
}
