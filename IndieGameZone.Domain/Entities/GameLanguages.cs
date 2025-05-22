namespace IndieGameZone.Domain.Entities
{
	public class GameLanguages
	{
		public Guid GameId { get; set; }
		public Guid LanguageId { get; set; }

		// Navigation properties
		public virtual Games Game { get; set; } = null!;
		public virtual Languages Language { get; set; } = null!;
	}
}
