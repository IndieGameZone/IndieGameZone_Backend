using IndieGameZone.Domain.Constants;

namespace IndieGameZone.Domain.RequestFeatures
{
	public class GameParameters : RequestParameters
	{
		public string? SearchTerm { get; set; }
		public CensorStatus? CensorStatus { get; set; }
	}
}
