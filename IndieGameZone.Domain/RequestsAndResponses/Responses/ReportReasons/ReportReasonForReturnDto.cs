using IndieGameZone.Domain.Constants;

namespace IndieGameZone.Domain.RequestsAndResponses.Responses.ReportReasons
{
	public class ReportReasonForReturnDto
	{
		public Guid Id { get; init; }
		public string Name { get; init; }
        public ReportReasonTypeEnum Type { get; init; }

    }
}
