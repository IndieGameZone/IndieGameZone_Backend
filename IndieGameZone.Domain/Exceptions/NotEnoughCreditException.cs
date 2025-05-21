namespace IndieGameZone.Domain.Exceptions
{
	public class NotEnoughCreditException : Exception
	{
		public NotEnoughCreditException(string? message) : base(message)
		{
		}
	}
}
