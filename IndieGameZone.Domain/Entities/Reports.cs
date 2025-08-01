using IndieGameZone.Domain.Constants;

namespace IndieGameZone.Domain.Entities
{
	public class Reports
	{
		public Guid Id { get; set; }
		public string Message { get; set; } = string.Empty;
		public DateTime CreatedAt { get; set; }
		public ReportStatus Status { get; set; } = ReportStatus.Pending;
        public string? ReviewMessage { get; set; }
        public Guid ReportingUserId { get; set; }
		public Guid? PostId { get; set; }
		public Guid ReportReasonId { get; set; }
		public Guid? GameId { get; set; }
		public Guid? CommentId { get; set; }

		//Navigation properties
		public virtual Users ReportingUser { get; set; } = null!;
		public virtual ReportReasons ReportReason { get; set; } = null!;
		public virtual Posts Post { get; set; } = null!;
		public virtual Games Game { get; set; } = null!;
		public virtual PostComments PostComment { get; set; } = null!;

	}
}
