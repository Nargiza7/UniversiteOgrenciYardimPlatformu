namespace CharitySosProje.Models
{
	public class HelpRequest
	{
		public int HelpRequestId { get; set; }
		public string Title { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public DateTime RequestDate { get; set; }
		public bool IsUrgent { get; set; }
		public int UserId { get; set; }
		public User? User { get; set; }  // Navigation property
		public int HelpCategoryId { get; set; }
		public HelpCategory? HelpCategory { get; set; } // Navigation property
		public int LocationId { get; set; }
		public Location? Location { get; set; } // Navigation property
		public ICollection<HelpTransaction>? HelpTransactions { get; set; }
	}
}
