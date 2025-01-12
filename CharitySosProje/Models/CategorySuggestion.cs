namespace CharitySosProje.Models
{
	public class CategorySuggestion
	{
		public int CategorySuggestionId { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }
		public string SuggestedCategoryName { get; set; } = string.Empty;
		public DateTime SuggestionDate { get; set; }
		public bool IsApproved { get; set; }
	}
}
