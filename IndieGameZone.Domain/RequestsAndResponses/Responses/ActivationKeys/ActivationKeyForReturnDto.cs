namespace IndieGameZone.Domain.RequestsAndResponses.Responses.ActivationKeys
{
	public class ActivationKeyForReturnDto
	{
		public Guid Id { get; init; }
		public string Key { get; init; }
		public bool IsUsed { get; init; }
		public bool IsActive { get; init; }
		public DateTime CreatedAt { get; init; }
	}
}
