using IndieGameZone.Domain.Constants;

namespace IndieGameZone.Domain.RequestFeatures
{
	public class ActiveGameParameters : RequestParameters
	{
		public string? SearchTerm { get; set; }
		public string? Price { get; set; }
		public bool HasDiscount { get; set; }
		public ICollection<Guid> Tags { get; set; } = new List<Guid>();
		public ICollection<Guid> Platforms { get; set; } = new List<Guid>();
		public ICollection<Guid> Languages { get; set; } = new List<Guid>();
		public Guid? Category { get; set; }
		public GameSortConstant? SortBy { get; set; }
		public bool SortDescending { get; set; } = true;
	}
}
