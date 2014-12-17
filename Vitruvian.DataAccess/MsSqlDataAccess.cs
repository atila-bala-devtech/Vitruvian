using Vitruvian.Shared;
using Vitruvian.Shared.Configuration;
using Vitruvian.Shared.DataAccess;
using Vitruvian.Shared.DataAccess.DataModels;

namespace Vitruvian.DataAccess
{
	public class MsSqlDataAccess : IDataAccess
	{
		public MsSqlDataAccess()
		{
			//"new" keyword inside a class isn't a good practice, but we'll keep doing it for the time being just to keep it simple.
			//the correct way to define dependency would be to "inject" it through the constructor
			IConfigurator config = new WebConfig();
			var msSqlConnectionString = string.Format("Data Source={0},{1};Initial Catalog={2};User Id={3};Password={4};", 
				config.Database.Host, config.Database.Port, config.Database.DatabaseName, config.Database.DatabaseUsername, config.Database.DatabasePassword);
		}

		public CustomerData GetCustomer(int customerId)
		{
			if (customerId != 1)
			{
				throw new DatabaseException(string.Format("There are no customers with id #{0}", customerId));
			}
			return new CustomerData
			{
				Address1 = "Mite Balije 69",
				Address2 = "Tu iza coska 23",
				Balance = 1000,
				Country = "Turkmenistan",
				FirstName = "Mitar",
				LastName = "Miric",
				IsActive = true,
				MiddleName = "GledamDrinu",
				Mobile = "064111111",
				PhoneNumber = "021123123"
			};
		}
	}
}