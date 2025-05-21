namespace IndieGameZone.Domain.Entities
{
	public class Achievements
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;

		//Navigation properties
		public virtual ICollection<Users> Users { get; set; } = new List<Users>();
	}
}
