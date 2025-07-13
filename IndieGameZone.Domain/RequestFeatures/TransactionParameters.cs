using IndieGameZone.Domain.Constants;

namespace IndieGameZone.Domain.RequestFeatures
{
	public class TransactionParameters : RequestParameters
	{
		public ICollection<TransactionType> TransactionTypes { get; set; } = new List<TransactionType>();
	}
}
