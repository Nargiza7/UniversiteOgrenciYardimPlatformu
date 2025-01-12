namespace CharitySosProje.Models
{
	public class HelpCategory
	{
		public int HelpCategoryId { get; set; }
		public string CategoryName { get; set; } = string.Empty; // Example: "Food", "Shelter"
		public ICollection<HelpRequest>? HelpRequests { get; set; }
	}
}
