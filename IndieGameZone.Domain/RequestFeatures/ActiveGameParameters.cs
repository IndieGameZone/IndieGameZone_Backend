namespace IndieGameZone.Domain.RequestFeatures
{
	public class ActiveGameParameters : RequestParameters
	{
		public string? SearchTerm { get; set; }
		public string? Price { get; set; }
		public ICollection<Guid> Tags { get; set; } = new List<Guid>();
		public ICollection<Guid> Platforms { get; set; } = new List<Guid>();
		public ICollection<Guid> Languages { get; set; } = new List<Guid>();
	}
}
