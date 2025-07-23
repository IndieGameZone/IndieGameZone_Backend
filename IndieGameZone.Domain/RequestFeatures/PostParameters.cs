namespace IndieGameZone.Domain.RequestFeatures
{
	public class PostParameters : RequestParameters
	{
		public ICollection<Guid> Tags { get; set; } = new List<Guid>();
	}
}
