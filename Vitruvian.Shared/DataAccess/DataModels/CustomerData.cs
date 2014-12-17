namespace Vitruvian.Shared.DataAccess.DataModels
{
	public class CustomerData
	{
		public bool IsActive { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public int Balance { get; set; }
		public string Country { get; set; }
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string PhoneNumber { get; set; }
		public string Mobile { get; set; }
	}
}