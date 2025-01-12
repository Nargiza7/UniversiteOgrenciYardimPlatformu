// HelpTransaction modeli, yardımseverler ile yardım talepleri arasındaki
// ilişkiyi ve yardımların işlem detaylarını izlemek için kullanılır.
// Bu model, projede yardım sürecini organize etmek ve ödüllendirme sistemini desteklemek için önemli bir yapıdır.

namespace CharitySosProje.Models
{
	public class HelpTransaction
	{
		public int HelpTransactionId { get; set; }
		public int HelpRequestId { get; set; }
		public HelpRequest? HelpRequest { get; set; } // Navigation property
		public int DonorId { get; set; }
		public User? Donor { get; set; } // Navigation property
		public DateTime TransactionDate { get; set; }
		public int DonorPoints { get; set; } // Points awarded for the help
	}
}
