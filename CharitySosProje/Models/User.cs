using Microsoft.AspNetCore.Http;
using System.Data;

namespace CharitySosProje.Models
{
	public class User
	{

		public int UserId { get; set; }
		public string FirstName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;	
		public string Email { get; set; } = string.Empty;
		public string PasswordHash { get; set; } = string.Empty;
		public string PhoneNumber { get; set; } = string.Empty;
		public string Nickname { get; set; } = string.Empty; // Unique identifier for anonymity
		public bool IsNameVisible { get; set; } // Determines if the name is visible to others
		public int RoleId { get; set; }
		public Role? Role { get; set; } // Navigation property	
		public ICollection<HelpRequest>? HelpRequests { get; set; }
		public ICollection<HelpTransaction>? HelpTransactions { get; set; }
	}
}
