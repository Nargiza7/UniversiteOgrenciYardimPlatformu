namespace CharitySosProje.Models
{
	public class Location
	{
		public int LocationId { get; set; } 
		public string City { get; set; }=string.Empty;
		public string UniversityName { get; set; } = string.Empty;
		public string District { get; set; } = string.Empty;
		public string AddressDetail { get; set; } = string.Empty;
		public ICollection<HelpRequest>? HelpRequests { get; set; }
	}
}
