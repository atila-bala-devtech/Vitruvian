namespace Vitruvian.Shared.Models
{
	public class Client
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Address { get; set; }
		public string Country { get; set; }
		public ClientStatus Status { get; set; }
	}
}