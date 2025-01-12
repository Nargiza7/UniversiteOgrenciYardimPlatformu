namespace CharitySosProje.Models
{
	public class Report
	{
		public int ReportId { get; set; }
		public int ReporterId { get; set; }
		public User? Reporter { get; set; }
		public int ReportedUserId { get; set; }
		public User? ReportedUser { get; set; }
		public string Reason { get; set; } = string.Empty;
		public DateTime ReportDate { get; set; }
		public bool IsResolved { get; set; }
	}
}
