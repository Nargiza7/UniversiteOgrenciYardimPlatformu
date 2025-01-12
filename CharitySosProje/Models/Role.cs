namespace CharitySosProje.Models
{
	public class Role
	{

		public int RoleId { get; set; }
		public string RoleName { get; set; } = string.Empty; // Example: "Donor" or "Recipient"
		public ICollection<User>? Users { get; set; }
	}
}
}
